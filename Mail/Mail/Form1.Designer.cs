
namespace Mail
{
    partial class Mail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextMail = new System.Windows.Forms.Label();
            this.panelAutentification = new System.Windows.Forms.Panel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.buttonAutentification = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxHosts = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.tabSendMessage = new System.Windows.Forms.TabControl();
            this.tabPageAutorisation = new System.Windows.Forms.TabPage();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.pictureBoxLoaderMessages = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.comboBoxFlags = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.buttonLastPageMessage = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNextPageMessage = new System.Windows.Forms.Button();
            this.labelCountMessage = new System.Windows.Forms.Label();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.pictureBoxLoaderFrom = new System.Windows.Forms.PictureBox();
            this.labelAttacmentsFrom = new System.Windows.Forms.Label();
            this.comboBoxAttacmentsDownload = new System.Windows.Forms.ComboBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.richTextBoxFrom = new System.Windows.Forms.RichTextBox();
            this.labelSubjectFrom = new System.Windows.Forms.Label();
            this.textBoxSubjectFrom = new System.Windows.Forms.TextBox();
            this.textBoxMailAddressFrom = new System.Windows.Forms.TextBox();
            this.labelMailAddresFrom = new System.Windows.Forms.Label();
            this.tabPageSendMessage = new System.Windows.Forms.TabPage();
            this.panelSendMessage = new System.Windows.Forms.Panel();
            this.buttonDeleteTo = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.pictureBoxLoaderTo = new System.Windows.Forms.PictureBox();
            this.labelAttacmentsTo = new System.Windows.Forms.Label();
            this.comboBoxAttacmentsUpload = new System.Windows.Forms.ComboBox();
            this.buttonUploadAttachments = new System.Windows.Forms.Button();
            this.richTextBoxTo = new System.Windows.Forms.RichTextBox();
            this.labelSubjectTo = new System.Windows.Forms.Label();
            this.textBoxSubjectTo = new System.Windows.Forms.TextBox();
            this.textBoxMailAddressTo = new System.Windows.Forms.TextBox();
            this.labelMailAdressTo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFlags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAttachments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAutentification.SuspendLayout();
            this.tabSendMessage.SuspendLayout();
            this.tabPageAutorisation.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderMessages)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.tabPageMessage.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderFrom)).BeginInit();
            this.tabPageSendMessage.SuspendLayout();
            this.panelSendMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TextMail
            // 
            resources.ApplyResources(this.TextMail, "TextMail");
            this.TextMail.Name = "TextMail";
            // 
            // panelAutentification
            // 
            this.panelAutentification.BackColor = System.Drawing.Color.White;
            this.panelAutentification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAutentification.Controls.Add(this.checkBoxRemember);
            this.panelAutentification.Controls.Add(this.buttonAutentification);
            this.panelAutentification.Controls.Add(this.labelPassword);
            this.panelAutentification.Controls.Add(this.comboBoxHosts);
            this.panelAutentification.Controls.Add(this.textBoxPassword);
            this.panelAutentification.Controls.Add(this.textBoxLogin);
            this.panelAutentification.Controls.Add(this.labelLogin);
            resources.ApplyResources(this.panelAutentification, "panelAutentification");
            this.panelAutentification.Name = "panelAutentification";
            // 
            // checkBoxRemember
            // 
            resources.ApplyResources(this.checkBoxRemember, "checkBoxRemember");
            this.checkBoxRemember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // buttonAutentification
            // 
            this.buttonAutentification.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonAutentification, "buttonAutentification");
            this.buttonAutentification.Name = "buttonAutentification";
            this.buttonAutentification.UseVisualStyleBackColor = false;
            this.buttonAutentification.Click += new System.EventHandler(this.buttonAutorisation_Click);
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Name = "labelPassword";
            // 
            // comboBoxHosts
            // 
            this.comboBoxHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxHosts, "comboBoxHosts");
            this.comboBoxHosts.FormattingEnabled = true;
            this.comboBoxHosts.Items.AddRange(new object[] {
            resources.GetString("comboBoxHosts.Items"),
            resources.GetString("comboBoxHosts.Items1"),
            resources.GetString("comboBoxHosts.Items2")});
            this.comboBoxHosts.Name = "comboBoxHosts";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // textBoxLogin
            // 
            resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
            this.textBoxLogin.Name = "textBoxLogin";
            // 
            // labelLogin
            // 
            resources.ApplyResources(this.labelLogin, "labelLogin");
            this.labelLogin.BackColor = System.Drawing.Color.White;
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogin.Name = "labelLogin";
            // 
            // labelError
            // 
            resources.ApplyResources(this.labelError, "labelError");
            this.labelError.Name = "labelError";
            // 
            // tabSendMessage
            // 
            this.tabSendMessage.Controls.Add(this.tabPageAutorisation);
            this.tabSendMessage.Controls.Add(this.tabPageMessages);
            this.tabSendMessage.Controls.Add(this.tabPageMessage);
            this.tabSendMessage.Controls.Add(this.tabPageSendMessage);
            resources.ApplyResources(this.tabSendMessage, "tabSendMessage");
            this.tabSendMessage.Name = "tabSendMessage";
            this.tabSendMessage.SelectedIndex = 0;
            // 
            // tabPageAutorisation
            // 
            this.tabPageAutorisation.BackColor = System.Drawing.Color.White;
            this.tabPageAutorisation.Controls.Add(this.panelAutentification);
            resources.ApplyResources(this.tabPageAutorisation, "tabPageAutorisation");
            this.tabPageAutorisation.Name = "tabPageAutorisation";
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.BackColor = System.Drawing.Color.White;
            this.tabPageMessages.Controls.Add(this.pictureBoxLoaderMessages);
            this.tabPageMessages.Controls.Add(this.panelButtons);
            this.tabPageMessages.Controls.Add(this.dataGridViewMessages);
            resources.ApplyResources(this.tabPageMessages, "tabPageMessages");
            this.tabPageMessages.Name = "tabPageMessages";
            // 
            // pictureBoxLoaderMessages
            // 
            this.pictureBoxLoaderMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLoaderMessages.Image = global::Mail.Properties.Resources.icons8_spinner;
            resources.ApplyResources(this.pictureBoxLoaderMessages, "pictureBoxLoaderMessages");
            this.pictureBoxLoaderMessages.Name = "pictureBoxLoaderMessages";
            this.pictureBoxLoaderMessages.TabStop = false;
            // 
            // panelButtons
            // 
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.BackColor = System.Drawing.SystemColors.Window;
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.labelFolder);
            this.panelButtons.Controls.Add(this.comboBoxFlags);
            this.panelButtons.Controls.Add(this.buttonDeleteSelected);
            this.panelButtons.Controls.Add(this.comboBoxFolders);
            this.panelButtons.Controls.Add(this.buttonLastPageMessage);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonNextPageMessage);
            this.panelButtons.Controls.Add(this.labelCountMessage);
            this.panelButtons.Name = "panelButtons";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelFolder
            // 
            resources.ApplyResources(this.labelFolder, "labelFolder");
            this.labelFolder.Name = "labelFolder";
            // 
            // comboBoxFlags
            // 
            this.comboBoxFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxFlags, "comboBoxFlags");
            this.comboBoxFlags.Items.AddRange(new object[] {
            resources.GetString("comboBoxFlags.Items"),
            resources.GetString("comboBoxFlags.Items1"),
            resources.GetString("comboBoxFlags.Items2"),
            resources.GetString("comboBoxFlags.Items3"),
            resources.GetString("comboBoxFlags.Items4"),
            resources.GetString("comboBoxFlags.Items5")});
            this.comboBoxFlags.Name = "comboBoxFlags";
            this.comboBoxFlags.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlags_SelectedIndexChanged);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonDeleteSelected, "buttonDeleteSelected");
            this.buttonDeleteSelected.FlatAppearance.BorderSize = 0;
            this.buttonDeleteSelected.Image = global::Mail.Properties.Resources.icons8_trash_can_24_1_;
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = false;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxFolders
            // 
            this.comboBoxFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxFolders, "comboBoxFolders");
            this.comboBoxFolders.Items.AddRange(new object[] {
            resources.GetString("comboBoxFolders.Items"),
            resources.GetString("comboBoxFolders.Items1"),
            resources.GetString("comboBoxFolders.Items2"),
            resources.GetString("comboBoxFolders.Items3"),
            resources.GetString("comboBoxFolders.Items4")});
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.SelectedIndexChanged += new System.EventHandler(this.comboBoxFolders_SelectedIndexChanged);
            // 
            // buttonLastPageMessage
            // 
            this.buttonLastPageMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonLastPageMessage, "buttonLastPageMessage");
            this.buttonLastPageMessage.FlatAppearance.BorderSize = 0;
            this.buttonLastPageMessage.Name = "buttonLastPageMessage";
            this.buttonLastPageMessage.UseVisualStyleBackColor = false;
            this.buttonLastPageMessage.Click += new System.EventHandler(this.buttonLastPageMessage_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.Image = global::Mail.Properties.Resources.icons8_rotate_24_1_;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNextPageMessage
            // 
            this.buttonNextPageMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonNextPageMessage, "buttonNextPageMessage");
            this.buttonNextPageMessage.FlatAppearance.BorderSize = 0;
            this.buttonNextPageMessage.Image = global::Mail.Properties.Resources.icons8_forward_24_1_;
            this.buttonNextPageMessage.Name = "buttonNextPageMessage";
            this.buttonNextPageMessage.UseVisualStyleBackColor = false;
            this.buttonNextPageMessage.Click += new System.EventHandler(this.buttonNextPageMessage_Click);
            // 
            // labelCountMessage
            // 
            resources.ApplyResources(this.labelCountMessage, "labelCountMessage");
            this.labelCountMessage.Name = "labelCountMessage";
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AllowUserToAddRows = false;
            this.dataGridViewMessages.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridViewMessages, "dataGridViewMessages");
            this.dataGridViewMessages.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMessages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect,
            this.ColumnFlags,
            this.ColumnDate,
            this.ColumnTime,
            this.ColumnFrom,
            this.ColumnSubject,
            this.ColumnAttachments,
            this.ColumnOpen,
            this.ColumnDelete});
            this.dataGridViewMessages.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMessages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMessages.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMessages.RowHeadersVisible = false;
            this.dataGridViewMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMessages.RowTemplate.Height = 33;
            this.dataGridViewMessages.RowTemplate.ReadOnly = true;
            this.dataGridViewMessages.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessages.ShowEditingIcon = false;
            this.dataGridViewMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMessages_CellContentClick);
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.panelMessage);
            resources.ApplyResources(this.tabPageMessage, "tabPageMessage");
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.pictureBoxLoaderFrom);
            this.panelMessage.Controls.Add(this.labelAttacmentsFrom);
            this.panelMessage.Controls.Add(this.comboBoxAttacmentsDownload);
            this.panelMessage.Controls.Add(this.buttonDownload);
            this.panelMessage.Controls.Add(this.richTextBoxFrom);
            this.panelMessage.Controls.Add(this.labelSubjectFrom);
            this.panelMessage.Controls.Add(this.textBoxSubjectFrom);
            this.panelMessage.Controls.Add(this.textBoxMailAddressFrom);
            this.panelMessage.Controls.Add(this.labelMailAddresFrom);
            resources.ApplyResources(this.panelMessage, "panelMessage");
            this.panelMessage.Name = "panelMessage";
            // 
            // pictureBoxLoaderFrom
            // 
            this.pictureBoxLoaderFrom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLoaderFrom.Image = global::Mail.Properties.Resources.icons8_spinner;
            resources.ApplyResources(this.pictureBoxLoaderFrom, "pictureBoxLoaderFrom");
            this.pictureBoxLoaderFrom.Name = "pictureBoxLoaderFrom";
            this.pictureBoxLoaderFrom.TabStop = false;
            // 
            // labelAttacmentsFrom
            // 
            resources.ApplyResources(this.labelAttacmentsFrom, "labelAttacmentsFrom");
            this.labelAttacmentsFrom.Name = "labelAttacmentsFrom";
            // 
            // comboBoxAttacmentsDownload
            // 
            this.comboBoxAttacmentsDownload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxAttacmentsDownload, "comboBoxAttacmentsDownload");
            this.comboBoxAttacmentsDownload.FormattingEnabled = true;
            this.comboBoxAttacmentsDownload.Name = "comboBoxAttacmentsDownload";
            // 
            // buttonDownload
            // 
            resources.ApplyResources(this.buttonDownload, "buttonDownload");
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.Image = global::Mail.Properties.Resources.icons8_download_32;
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // richTextBoxFrom
            // 
            this.richTextBoxFrom.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.richTextBoxFrom, "richTextBoxFrom");
            this.richTextBoxFrom.Name = "richTextBoxFrom";
            this.richTextBoxFrom.ReadOnly = true;
            // 
            // labelSubjectFrom
            // 
            resources.ApplyResources(this.labelSubjectFrom, "labelSubjectFrom");
            this.labelSubjectFrom.Name = "labelSubjectFrom";
            // 
            // textBoxSubjectFrom
            // 
            resources.ApplyResources(this.textBoxSubjectFrom, "textBoxSubjectFrom");
            this.textBoxSubjectFrom.Name = "textBoxSubjectFrom";
            // 
            // textBoxMailAddressFrom
            // 
            resources.ApplyResources(this.textBoxMailAddressFrom, "textBoxMailAddressFrom");
            this.textBoxMailAddressFrom.Name = "textBoxMailAddressFrom";
            // 
            // labelMailAddresFrom
            // 
            resources.ApplyResources(this.labelMailAddresFrom, "labelMailAddresFrom");
            this.labelMailAddresFrom.Name = "labelMailAddresFrom";
            // 
            // tabPageSendMessage
            // 
            this.tabPageSendMessage.Controls.Add(this.panelSendMessage);
            resources.ApplyResources(this.tabPageSendMessage, "tabPageSendMessage");
            this.tabPageSendMessage.Name = "tabPageSendMessage";
            this.tabPageSendMessage.UseVisualStyleBackColor = true;
            // 
            // panelSendMessage
            // 
            this.panelSendMessage.Controls.Add(this.buttonDeleteTo);
            this.panelSendMessage.Controls.Add(this.buttonSendMessage);
            this.panelSendMessage.Controls.Add(this.pictureBoxLoaderTo);
            this.panelSendMessage.Controls.Add(this.labelAttacmentsTo);
            this.panelSendMessage.Controls.Add(this.comboBoxAttacmentsUpload);
            this.panelSendMessage.Controls.Add(this.buttonUploadAttachments);
            this.panelSendMessage.Controls.Add(this.richTextBoxTo);
            this.panelSendMessage.Controls.Add(this.labelSubjectTo);
            this.panelSendMessage.Controls.Add(this.textBoxSubjectTo);
            this.panelSendMessage.Controls.Add(this.textBoxMailAddressTo);
            this.panelSendMessage.Controls.Add(this.labelMailAdressTo);
            resources.ApplyResources(this.panelSendMessage, "panelSendMessage");
            this.panelSendMessage.Name = "panelSendMessage";
            // 
            // buttonDeleteTo
            // 
            this.buttonDeleteTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonDeleteTo, "buttonDeleteTo");
            this.buttonDeleteTo.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTo.Image = global::Mail.Properties.Resources.icons8_trash_can_24_1_;
            this.buttonDeleteTo.Name = "buttonDeleteTo";
            this.buttonDeleteTo.UseVisualStyleBackColor = false;
            this.buttonDeleteTo.Click += new System.EventHandler(this.buttonDeleteTo_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonSendMessage, "buttonSendMessage");
            this.buttonSendMessage.Image = global::Mail.Properties.Resources.icons8_sent_24;
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // pictureBoxLoaderTo
            // 
            this.pictureBoxLoaderTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLoaderTo.Image = global::Mail.Properties.Resources.icons8_spinner;
            resources.ApplyResources(this.pictureBoxLoaderTo, "pictureBoxLoaderTo");
            this.pictureBoxLoaderTo.Name = "pictureBoxLoaderTo";
            this.pictureBoxLoaderTo.TabStop = false;
            // 
            // labelAttacmentsTo
            // 
            resources.ApplyResources(this.labelAttacmentsTo, "labelAttacmentsTo");
            this.labelAttacmentsTo.Name = "labelAttacmentsTo";
            // 
            // comboBoxAttacmentsUpload
            // 
            this.comboBoxAttacmentsUpload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxAttacmentsUpload, "comboBoxAttacmentsUpload");
            this.comboBoxAttacmentsUpload.FormattingEnabled = true;
            this.comboBoxAttacmentsUpload.Items.AddRange(new object[] {
            resources.GetString("comboBoxAttacmentsUpload.Items")});
            this.comboBoxAttacmentsUpload.Name = "comboBoxAttacmentsUpload";
            // 
            // buttonUploadAttachments
            // 
            this.buttonUploadAttachments.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonUploadAttachments, "buttonUploadAttachments");
            this.buttonUploadAttachments.Image = global::Mail.Properties.Resources.icons8_upload_32;
            this.buttonUploadAttachments.Name = "buttonUploadAttachments";
            this.buttonUploadAttachments.UseVisualStyleBackColor = true;
            this.buttonUploadAttachments.Click += new System.EventHandler(this.buttonUploadAttachments_Click);
            // 
            // richTextBoxTo
            // 
            resources.ApplyResources(this.richTextBoxTo, "richTextBoxTo");
            this.richTextBoxTo.Name = "richTextBoxTo";
            // 
            // labelSubjectTo
            // 
            resources.ApplyResources(this.labelSubjectTo, "labelSubjectTo");
            this.labelSubjectTo.Name = "labelSubjectTo";
            // 
            // textBoxSubjectTo
            // 
            resources.ApplyResources(this.textBoxSubjectTo, "textBoxSubjectTo");
            this.textBoxSubjectTo.Name = "textBoxSubjectTo";
            // 
            // textBoxMailAddressTo
            // 
            resources.ApplyResources(this.textBoxMailAddressTo, "textBoxMailAddressTo");
            this.textBoxMailAddressTo.Name = "textBoxMailAddressTo";
            // 
            // labelMailAdressTo
            // 
            resources.ApplyResources(this.labelMailAdressTo, "labelMailAdressTo");
            this.labelMailAdressTo.Name = "labelMailAdressTo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FalseValue = "0";
            resources.ApplyResources(this.ColumnSelect, "ColumnSelect");
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.ReadOnly = true;
            this.ColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSelect.TrueValue = "1";
            // 
            // ColumnFlags
            // 
            this.ColumnFlags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnFlags, "ColumnFlags");
            this.ColumnFlags.Name = "ColumnFlags";
            this.ColumnFlags.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnDate, "ColumnDate");
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnTime, "ColumnTime");
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnFrom
            // 
            this.ColumnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnFrom, "ColumnFrom");
            this.ColumnFrom.Name = "ColumnFrom";
            this.ColumnFrom.ReadOnly = true;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSubject.FillWeight = 256.6308F;
            resources.ApplyResources(this.ColumnSubject, "ColumnSubject");
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnAttachments
            // 
            this.ColumnAttachments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAttachments.FillWeight = 42.32328F;
            resources.ApplyResources(this.ColumnAttachments, "ColumnAttachments");
            this.ColumnAttachments.Name = "ColumnAttachments";
            this.ColumnAttachments.ReadOnly = true;
            this.ColumnAttachments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAttachments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnOpen
            // 
            this.ColumnOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnOpen.Description = "123";
            resources.ApplyResources(this.ColumnOpen, "ColumnOpen");
            this.ColumnOpen.Image = global::Mail.Properties.Resources.icons8_enter_24;
            this.ColumnOpen.Name = "ColumnOpen";
            this.ColumnOpen.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.ColumnDelete, "ColumnDelete");
            this.ColumnDelete.Image = global::Mail.Properties.Resources.icons8_trash_can_24_1_;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Mail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabSendMessage);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.TextMail);
            this.Name = "Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAutentification.ResumeLayout(false);
            this.panelAutentification.PerformLayout();
            this.tabSendMessage.ResumeLayout(false);
            this.tabPageAutorisation.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderMessages)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.tabPageMessage.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderFrom)).EndInit();
            this.tabPageSendMessage.ResumeLayout(false);
            this.panelSendMessage.ResumeLayout(false);
            this.panelSendMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaderTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextMail;
        private System.Windows.Forms.Panel panelAutentification;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAutentification;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TabControl tabSendMessage;
        private System.Windows.Forms.TabPage tabPageAutorisation;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.ComboBox comboBoxHosts;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelCountMessage;
        private System.Windows.Forms.Button buttonLastPageMessage;
        private System.Windows.Forms.Button buttonNextPageMessage;
        private System.Windows.Forms.PictureBox pictureBoxLoaderMessages;
        private System.Windows.Forms.ComboBox comboBoxFolders;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.RichTextBox richTextBoxFrom;
        private System.Windows.Forms.Label labelSubjectFrom;
        private System.Windows.Forms.TextBox textBoxSubjectFrom;
        private System.Windows.Forms.TextBox textBoxMailAddressFrom;
        private System.Windows.Forms.Label labelMailAddresFrom;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label labelAttacmentsFrom;
        private System.Windows.Forms.ComboBox comboBoxAttacmentsDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxLoaderFrom;
        private System.Windows.Forms.ComboBox comboBoxFlags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TabPage tabPageSendMessage;
        private System.Windows.Forms.Panel panelSendMessage;
        private System.Windows.Forms.PictureBox pictureBoxLoaderTo;
        private System.Windows.Forms.Label labelAttacmentsTo;
        private System.Windows.Forms.ComboBox comboBoxAttacmentsUpload;
        private System.Windows.Forms.Button buttonUploadAttachments;
        private System.Windows.Forms.RichTextBox richTextBoxTo;
        private System.Windows.Forms.Label labelSubjectTo;
        private System.Windows.Forms.TextBox textBoxSubjectTo;
        private System.Windows.Forms.TextBox textBoxMailAddressTo;
        private System.Windows.Forms.Label labelMailAdressTo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Button buttonDeleteTo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFlags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAttachments;
        private System.Windows.Forms.DataGridViewImageColumn ColumnOpen;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}

