using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Search;
using Microsoft.Win32;
using MimeKit;

namespace Mail
{
    public partial class Mail : Form
    {
        string mailAddress;
        const int countMessageInPage = 20;
        int indexBeginPage, indexEndPage;

        MailClient mailClient;
        IList<IMessageSummary> messages;
        MimeMessage message;

        Dictionary<string, SearchQuery> dictQueryFlags = new Dictionary<string, SearchQuery> {
            {"All messages", SearchQuery.All},
            {"Seen", SearchQuery.Seen},
            {"Not seen", SearchQuery.NotSeen},
            {"Not answered", SearchQuery.NotAnswered},
            {"Answered", SearchQuery.Answered},
            {"Flagged", SearchQuery.Flagged},
        };


        Dictionary<string, SpecialFolder> dictSpecialFolders = new Dictionary<string, SpecialFolder> {
            {"All messages", SpecialFolder.All},
            {"Inbox", SpecialFolder.Important},
            {"Spam", SpecialFolder.Junk},
            {"Trash can", SpecialFolder.Trash},
            {"Important", SpecialFolder.Flagged},
            {"Draft", SpecialFolder.Drafts},
            {"Sent", SpecialFolder.Sent},
            {"Archive", SpecialFolder.Archive},
        };


        List<int> indexesOfSelectedMessage;

        public Mail()
        {
            InitializeComponent();
            mailClient = new MailClient();
            message = new MimeMessage();
            indexesOfSelectedMessage = new List<int>();
            comboBoxFolders.SelectedIndex = 0;
            comboBoxHosts.SelectedIndex = 0;
            comboBoxFlags.SelectedIndex = 0;
            comboBoxAttacmentsUpload.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey mailClientKey = Registry.CurrentUser.OpenSubKey("MailClient");
            if (mailClientKey != null)
            {
                textBoxLogin.Text = mailClientKey.GetValue("login").ToString();
                mailClientKey.Close();
            }
            else
            {
                textBoxLogin.Focus();
            }
        }

        private bool CheckTheField(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                return false;
            }
            return true;
        }

        private async Task UpdateMessageAsync(SpecialFolder folder)
        {
            pictureBoxLoaderMessages.Visible = true;
            panelButtons.Enabled = false;
            indexesOfSelectedMessage.Clear();
            try
            {
                messages = await mailClient.GetMessageSummaryAsync(folder);
                if (messages != null && messages.Count != 0)
                {
                    ShowListMessages(0, messages.Count > countMessageInPage ?
                        countMessageInPage : messages.Count);
                }
                else
                {
                    dataGridViewMessages.Rows.Clear();
                    labelCountMessage.Text = "Mail folder is empty";
                }
            }
            catch (MailClientExeption m)
            {
                ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
            }
            finally
            {
                panelButtons.Enabled = true;
                pictureBoxLoaderMessages.Visible = false;
            }
        }

        private async Task UpdateMessageAsync(SearchQuery query)
        {
            pictureBoxLoaderMessages.Visible = true;
            panelButtons.Enabled = false;
            indexesOfSelectedMessage.Clear();
            try
            {
                messages = await mailClient.GetMessageSummaryAsync(query);
                if (messages != null && messages.Count != 0)
                {
                    ShowListMessages(0, messages.Count > countMessageInPage ?
                        countMessageInPage : messages.Count);
                }
                else
                {
                    dataGridViewMessages.Rows.Clear();
                    labelCountMessage.Text = "Mail folder is empty";
                }
            }
            catch (MailClientExeption m)
            {
                ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
            }
            finally
            {
                panelButtons.Enabled = true;
                pictureBoxLoaderMessages.Visible = false;
            }
        }


        private void ShowListMessages(int indexBegin, int indexEnd)
        {
            indexBeginPage = indexBegin;
            indexEndPage = indexEnd;
            labelCountMessage.Text = $"Showed message {indexBegin + 1} - {indexEnd} of {messages.Count}";
            dataGridViewMessages.Rows.Clear();

            for (int i = indexBegin; i < indexEnd; i++)
            {
                var hasSelected = indexesOfSelectedMessage.Exists(x => x == messages.Count - 1 - i);
                var index = messages.Count - 1 - i;
                var stringDate = messages[index].Date.ToString().Split(' ');
                var stringFrom = messages[index].Envelope.From.ToString().Split('<');
                var stringAttachments = "";
                foreach (var attachment in messages[index].Attachments)
                {
                    stringAttachments += $"{attachment.ContentDisposition.FileName}, ";
                }
                var flag = messages[index].Flags.HasValue ? messages[index].Flags.Value.ToString() : "";

                dataGridViewMessages.Rows.Add(hasSelected, flag, stringDate[0], stringDate[1], stringFrom[0],
                    messages[index].Envelope.Subject, stringAttachments);
            }
        }

        private async Task ShowMessage(int index) 
        {
            tabSendMessage.SelectedTab = tabPageMessage;
            buttonDownload.Enabled = false;
            pictureBoxLoaderFrom.Visible = true;

            try
            {
                message = await mailClient.GetMimeMessageAsync(messages[index].UniqueId);
                if(messages[index].Flags.ToString().IndexOf("None") >= 0)
                    await mailClient.AddMessageFlags(messages[index].UniqueId, MessageFlags.Seen);
                
                comboBoxAttacmentsDownload.Items.Clear();

                textBoxMailAddressFrom.Text = message.From.ToString();
                textBoxSubjectFrom.Text = message.Subject;
                richTextBoxFrom.Text = message.TextBody;

                comboBoxAttacmentsDownload.Items.Add(message.Attachments.Count() > 0 ? "Download all files" : "No files");
                foreach (var file in message.Attachments)
                {
                    comboBoxAttacmentsDownload.Items.Add(file.ContentDisposition.FileName);
                }
                comboBoxAttacmentsDownload.SelectedIndex = message.Attachments.Count() > 0 ? 1 : 0;
            }
            catch (MailClientExeption m)
            {
                ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
            }
            finally
            {
                pictureBoxLoaderFrom.Visible = false;
                buttonDownload.Enabled = true;
            }
        }

        private async void buttonAutorisation_Click(object sender, EventArgs e)
        {
            if (CheckTheField(textBoxLogin) && CheckTheField(textBoxPassword))
            {
                buttonAutentification.Enabled = false;

                mailAddress = textBoxLogin.Text + "@" + comboBoxHosts.Text;
                mailClient.HostName = comboBoxHosts.Text;
                try
                {
                    await mailClient.AutorisationAsync(mailAddress, textBoxPassword.Text);
                    if (checkBoxRemember.Checked)
                    {
                        RegistryKey currentUserKey = Registry.CurrentUser;
                        RegistryKey mailClientKey = currentUserKey.CreateSubKey("MailClient");
                        mailClientKey.SetValue("login", textBoxLogin.Text);
                        //mailClientKey.SetValue("password", textBoxPassword.Text);
                        mailClientKey.Close();
                    }

                    tabSendMessage.SelectedTab = tabPageMessages;
                    panelMessage.Enabled = true;
                    panelSendMessage.Enabled = true;
                    await UpdateMessageAsync(SearchQuery.All);
                }
                catch(MailClientExeption m)
                {
                    ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
                }
                finally
                {
                    buttonAutentification.Enabled = true;
                }
            }
        }

        private DialogResult GetResultMessageBox(string message)
        {
            return MessageBox.Show(message, "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void dataGridViewMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int indexMessage = messages.Count - 1 - indexBeginPage - e.RowIndex;
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            if (Convert.ToBoolean(dataGridViewMessages.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                            {
                                indexesOfSelectedMessage.Remove(indexMessage);

                                dataGridViewMessages.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                            }
                            else
                            {
                                indexesOfSelectedMessage.Add(indexMessage);

                                dataGridViewMessages.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                            }
                            break;
                        }
                    case 7:
                        {
                            await ShowMessage(indexMessage);
                            break;
                        }
                    case 8:
                        {
                            if (GetResultMessageBox("Delete this message?") == DialogResult.Yes)
                            {
                                try
                                {
                                    await mailClient.AddMessageFlags(messages[indexMessage].UniqueId, MessageFlags.Deleted);
                                    await UpdateMessageAsync(SearchQuery.All);
                                }
                                catch (MailClientExeption m)
                                {
                                    ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
                                }
                            }
                            break;
                        }
                }
            }
        }

        private void buttonNextPageMessage_Click(object sender, EventArgs e)
        {
            if (indexEndPage < messages.Count - 1)
            {
                ShowListMessages(indexEndPage, messages.Count > indexEndPage + countMessageInPage ?
                    indexEndPage + countMessageInPage : messages.Count);
            }
        }

        private void buttonLastPageMessage_Click(object sender, EventArgs e)
        {
            if (indexBeginPage != 0)
            {
                ShowListMessages(indexBeginPage - countMessageInPage, indexBeginPage);
            }
        }

        private async Task DownloadFile(MimeEntity entity)
        {
            buttonDownload.Enabled = false;
            pictureBoxLoaderFrom.Visible = true;


            saveFileDialog.FileName = entity.ContentDisposition.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (entity is MessagePart)
                {
                    var rfc822 = (MessagePart)entity;
                    await rfc822.Message.WriteToAsync(saveFileDialog.OpenFile());
                }
                else
                {
                    var part = (MimePart)entity;
                    await part.Content.DecodeToAsync(saveFileDialog.OpenFile());
                }
            }
            buttonDownload.Enabled = true;
            pictureBoxLoaderFrom.Visible = false;
        }


        private void UploadFile()
        {
            buttonUploadAttachments.Enabled = false;
            pictureBoxLoaderTo.Visible = true;
            openFileDialog.FileName = "";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (comboBoxAttacmentsUpload.Items[0].ToString() == "No files")
                    comboBoxAttacmentsUpload.Items.Clear();

                foreach (var fileName in openFileDialog.FileNames)
                {
                    if (comboBoxAttacmentsUpload.Items.IndexOf(fileName) == -1)
                        comboBoxAttacmentsUpload.Items.Add(fileName);
                }
                comboBoxAttacmentsUpload.SelectedIndex = 0;
            }
            buttonUploadAttachments.Enabled = true;
            pictureBoxLoaderTo.Visible = false;
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            var itemString = comboBoxAttacmentsDownload.SelectedItem.ToString();
            if (itemString == "Download all files")
            {
                foreach (var entity in message.Attachments)
                {
                    await DownloadFile(entity);
                }
                ShowMessageBox("Files saved successfully");
            }
            else if (itemString == "No files")
            {
                ShowErrorMessageBox("No files");
            }
            else
            {
                await DownloadFile(message.Attachments.ToList()[comboBoxAttacmentsDownload.SelectedIndex - 1]);
                ShowMessageBox("File saved successfully");
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (GetResultMessageBox($"Delete {indexesOfSelectedMessage.Count} messages?") == DialogResult.Yes)
            {
                pictureBoxLoaderMessages.Visible = true;
                try
                {
                    foreach (int indexMessage in indexesOfSelectedMessage)
                    {
                        await mailClient.AddMessageFlags(messages[indexMessage].UniqueId, MessageFlags.Deleted);
                    }
                    await UpdateMessageAsync(dictQueryFlags[comboBoxFlags.Text]);
                }
                catch (MailClientExeption m)
                {
                    ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
                }
                finally
                {
                    pictureBoxLoaderMessages.Visible = false;
                }
            }
        }

        private async void comboBoxFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mailClient.imapIsConnect())
                await UpdateMessageAsync(dictQueryFlags[comboBoxFlags.Text]);
        }

        private async void comboBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mailClient.imapIsConnect())
                await UpdateMessageAsync(dictSpecialFolders[comboBoxFolders.Text]);
        }

        private async void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (CheckTheField(textBoxMailAddressTo) && CheckTheField(textBoxSubjectTo))
            {
                pictureBoxLoaderTo.Visible = true;
                buttonDeleteTo.Enabled = false;
                buttonUploadAttachments.Enabled = false;

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(mailAddress));
                email.To.Add(MailboxAddress.Parse(textBoxMailAddressTo.Text));
                email.Subject = textBoxSubjectTo.Text;

                var builder = new BodyBuilder();
                builder.TextBody = richTextBoxTo.Text;
                if (comboBoxAttacmentsUpload.Items[0].ToString() != "No files")
                {
                    foreach (string fileName in comboBoxAttacmentsUpload.Items)
                    {
                        builder.Attachments.Add(fileName);
                    }
                }
                email.Body = builder.ToMessageBody();

                try
                {
                    await mailClient.SendMessageAsync(email);
                    ShowMessageBox("The message was sent");
                }
                catch (MailClientExeption m)
                {
                    ShowErrorMessageBox($"{m.Message}: {m.InnerException.Message}");
                }
                finally
                {
                    pictureBoxLoaderTo.Visible = false;
                    buttonDeleteTo.Enabled = true;
                    buttonUploadAttachments.Enabled = true;
                }
            }
        }

        private void buttonUploadAttachments_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void buttonDeleteTo_Click(object sender, EventArgs e)
        {
            if (comboBoxAttacmentsUpload.Items[0].ToString() == "No files")
                ShowErrorMessageBox("No files");
            else
            {
                comboBoxAttacmentsUpload.Items.Clear();
                comboBoxAttacmentsUpload.Items.Add("No files");
                comboBoxAttacmentsUpload.SelectedIndex = 0;
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            await UpdateMessageAsync(SearchQuery.All);
        }
    }
}
