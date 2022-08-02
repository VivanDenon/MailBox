using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;

namespace Mail
{
    class MailClient
    {
        readonly ImapClient imap;
        IMailFolder folder;

        int portImap = 993, portStmp = 465;
        string mailAddress, password, hostName;

        public MailClient(string hostName)
        {
            HostName = hostName;
            imap = new ImapClient();
            imap.CheckCertificateRevocation = false;
        }

        public MailClient()
        {
            imap = new ImapClient();
            imap.CheckCertificateRevocation = false;
        }

        public string MailAddress { get => mailAddress; set => mailAddress = value; }
        public string HostName { get => hostName; set => hostName = value; }
        public string Password { get => password; set => password = value; }


        public bool imapIsConnect()
        {
            return imap.IsConnected;
        }

        public async Task AutorisationAsync(string mailAddress, string password)
        {
            MailAddress = mailAddress;
            Password = password;
            try
            {
                await imap.ConnectAsync("imap." + hostName, portImap, MailKit.Security.SecureSocketOptions.SslOnConnect);
                await imap.AuthenticateAsync(mailAddress, password);
            }
            catch (MailKit.Security.AuthenticationException e)
            {
                await DisconnectToImapAsync();
                throw new MailClientExeption("Authentication error", e);
            }
            catch (System.Net.Sockets.SocketException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }

        public async Task<IList<IMessageSummary>> GetMessageSummaryAsync(SearchQuery query)
        {
            try
            {
                folder = imap.Inbox;
                await folder.OpenAsync(FolderAccess.ReadOnly);
                var uids = await folder.SearchAsync(query);
                return await folder.FetchAsync(uids, MessageSummaryItems.Envelope | MessageSummaryItems.BodyStructure | MessageSummaryItems.Flags);
            }
            catch (MessageNotFoundException e)
            { 
                throw new MailClientExeption("Message not found", e);
            }
            catch (ServiceNotConnectedException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }

        public async Task<IList<IMessageSummary>> GetMessageSummaryAsync(SpecialFolder specialFolder)
        {
            try
            {
                folder = imap.GetFolder(specialFolder);
                if (folder == null)
                    return null;
                await folder.OpenAsync(FolderAccess.ReadOnly);
                var uids = await folder.SearchAsync(SearchQuery.All);
                return await folder.FetchAsync(uids, MessageSummaryItems.Envelope | MessageSummaryItems.BodyStructure | MessageSummaryItems.Flags);
            }
            catch (MessageNotFoundException e)
            {
                throw new MailClientExeption("Message not found", e);
            }
            catch (ServiceNotConnectedException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }

        public async Task<MimeMessage> GetMimeMessageAsync(UniqueId uid)
        {
            try
            {
                await folder.OpenAsync(FolderAccess.ReadOnly);
                return await folder.GetMessageAsync(uid);
            }
            catch (ServiceNotConnectedException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }

        public async Task AddMessageFlags(UniqueId uid, MessageFlags flag)
        {
            try
            {
                await folder.OpenAsync(FolderAccess.ReadWrite);
                await folder.AddFlagsAsync(uid, flag, false);
                await folder.ExpungeAsync();
            }
            catch (ServiceNotConnectedException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }


        public async Task DisconnectToImapAsync()
        {
            await imap.DisconnectAsync(true);
        }

        public async Task SendMessageAsync(MimeMessage message)
        {
            try
            {
                var smtp = new SmtpClient();
                smtp.CheckCertificateRevocation = false;
                await smtp.ConnectAsync("smtp." + hostName, portStmp, MailKit.Security.SecureSocketOptions.SslOnConnect);
                await smtp.AuthenticateAsync(mailAddress, Password);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);
            }
            catch (MailKit.Security.AuthenticationException e)
            {
                throw new MailClientExeption("Authentication error", e);
            }
            catch (System.Net.Sockets.SocketException e)
            {
                throw new MailClientExeption("Connection error", e);
            }
            catch (CommandException e)
            {
                throw new MailClientExeption("Incorrect adress", e);
            }
            catch (Exception e)
            {
                throw new MailClientExeption("Error", e);
            }
        }
    }
}
