/*
 * Author       : Quaint Park
 * Copyright    : © 2014 Quaint Park.
 * Website      : www.quaintpark.com
 * -------------------------------------------
 * Developed By : Jeshad Khan
 * Profile      : www.github.com/JeshadKhan
 * -------------------------------------------
 * Release      : 2014
 * Re-Release   : 2017
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmailSender;
using EmailSender.UI;
using EmailSender.ProClass;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace EmailSender
{
    public partial class frmMain : Form
    {
        /* Initialize Variable */

        int statusFlag = 0;
        string appSrartPath = string.Empty;



        /* Initialize Property */

        public bool Status { get; set; }
        public bool AlwaysOnTop { get; set; }



        /* Control Method Functionality */

        public frmMain()
        {
            InitializeComponent();
        }

        // Tool Functionality
        #region Tool Functionality

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClearField();
                AppStatus("Cleared.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Refresh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
                notifyIconMinimizeToTray.Visible = true;
                notifyIconMinimizeToTray.ShowBalloonTip(500);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Minimize to System Tray.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notifyIconMinimizeToTray_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
                notifyIconMinimizeToTray.Visible = false;
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Reform Window.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to Restart the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Restart();
                    AppStatus("Application Restarted.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Restart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus("Exit message showed.");

                if (MessageBox.Show("Are you sure want to Exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (((ToolStripMenuItem)optionToolStripMenuItem.DropDownItems[0]).Checked == false)
                {
                    ((ToolStripMenuItem)optionToolStripMenuItem.DropDownItems[0]).Checked = true;
                    this.TopMost = true;
                    this.AlwaysOnTop = true;
                    AppStatus("Enable: Always on Top.");
                }
                else
                {
                    ((ToolStripMenuItem)optionToolStripMenuItem.DropDownItems[0]).Checked = false;
                    this.TopMost = false;
                    this.AlwaysOnTop = false;
                    AppStatus("Disable: Always on Top.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to change option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();
                pll.HelpViewer(appSrartPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to View Help.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();
                pll.WebLinkApp();
                AppStatus("Open Update.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutEmailSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeveloper dev = new frmDeveloper();
                dev.AlwaysOnTop = this.AlwaysOnTop;
                dev.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to open application short brief.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // Form Functionality
        #region Form Functionality

        private void btnUploadAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus("Browse for Attachment.");

                openFileDialog.Filter = "All Documents|*.jk;*.txt;*.rtf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pps;*.pdf;*.htm;*.html;*.css;*.js;*.zip;*.rar;*.jpg;*.jpeg;*.gif;*.png;*.ico;*.bmp;*.tif;*.tiff;*.mp3;*.wav;*.mp4;*.3gp;*.3gpp;*.avi;*.mpg;*.mpeg;*.wmv;*.mkv;*.swf;*.flv;*.vob;*.mov";
                DialogResult dlgResult = openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName.ToString();
                FileInfo fileInfo = new FileInfo(fileName);
                double fileSize = (fileInfo.Length / 1024) / 1024.0;

                if (dlgResult == DialogResult.OK)
                {
                    if (fileSize < 25.0)
                    {
                        txtbxEmailAttachment.Text = fileName;
                        AppStatus("File Attached");
                    }
                    else
                    {
                        AppStatus("File size should not more than 25 MB.");
                        MessageBox.Show("File size should not more than 25 MB.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Browse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                AppStatus("Checking...");

                if (string.IsNullOrEmpty(txtbxToEmail.Text.Trim()))
                {
                    AppStatus("Receiver required.");
                    txtbxToEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtbxFromEmail.Text.Trim()))
                {
                    AppStatus("Sender required.");
                    txtbxFromEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtbxPasswordFromEmail.Text.Trim()))
                {
                    AppStatus("Sender Password required.");
                    txtbxPasswordFromEmail.Focus();
                }
                else if (string.IsNullOrEmpty(txtbxEmailSubject.Text.Trim()))
                {
                    if (MessageBox.Show("Without a subject email will be sent as spam.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        txtbxEmailSubject.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txtbxEmailBody.Text.Trim()))
                {
                    if (MessageBox.Show("Message field is empty.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        txtbxEmailBody.Focus();
                    }
                }
                else
                {
                    CheckEmailValidity();

                    if (Status)
                    {
                        AppStatus("Sending email...");
                        SendEmail();
                    }
                }
            }
            catch (Exception)
            {
                AppStatus("Faild to Send Email. Check your inputs!");
                MessageBox.Show("Failed to Send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                AppStatus("Loading.");

                frmFlashScreen flashScreen = new frmFlashScreen();
                flashScreen.ShowDialog();

                appSrartPath = Application.StartupPath;
                ClearField();
                statusFlag = 0;
                ((ToolStripMenuItem)optionToolStripMenuItem.DropDownItems[0]).Checked = false;

                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(this.btnUploadAttachment, "Browse");

                tlstrpStatusLabel.Text = string.Empty;
                AppStatus("Ready.");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();
                pll.CloseHelpViewer();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Close properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // Main Process
        #region  Main Functionality

        protected void errMsg()
        {
            MessageBox.Show("Internal error occurred. Please, Restart the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void AppStatus(string statusMsg)
        {
            try
            {
                string oldStatusMsg = tlstrpStatusLabel.Text.Trim().ToString();

                if (oldStatusMsg != statusMsg)
                {
                    tlstrpStatusLabel.Text = statusMsg;
                }
            }
            catch (Exception)
            {
                errMsg();
            }
        }

        protected void ClearField()
        {
            try
            {
                txtbxToEmail.Text = string.Empty;
                txtbxCCEmail.Text = string.Empty;
                txtbxBCCEmail.Text = string.Empty;
                txtbxReplyToEmail.Text = string.Empty;
                txtbxFromEmail.Text = string.Empty;
                txtbxPasswordFromEmail.Text = string.Empty;
                txtbxEmailSubject.Text = string.Empty;
                txtbxEmailBody.Text = string.Empty;
                txtbxEmailAttachment.Text = string.Empty;

                cmbbxPriority.SelectedIndex = 1;
                cmbbxSMTP.SelectedIndex = 0;

                Status = false;
            }
            catch (Exception)
            {
                errMsg();
            }
        }

        protected void CheckEmailValidity()
        {
            try
            {
                ProLogicLayer pll = new ProLogicLayer();

                if (!string.IsNullOrEmpty(txtbxToEmail.Text.Trim().ToString()))
                {
                    if (!pll.IsValidEmail(txtbxToEmail.Text.Trim().ToString()))
                    {
                        Status = false;
                        statusFlag++;
                        txtbxToEmail.Focus();
                        AppStatus("Check email address. Example: \"example@domain.com\".");
                    }
                }
                else if (!string.IsNullOrEmpty(txtbxCCEmail.Text.Trim().ToString()))
                {
                    if (!pll.IsValidEmail(txtbxCCEmail.Text.Trim().ToString()))
                    {
                        Status = false;
                        statusFlag++;
                        txtbxCCEmail.Focus();
                        AppStatus("Check email address. Example: \"example@domain.com\".");
                    }
                }
                else if (!string.IsNullOrEmpty(txtbxBCCEmail.Text.Trim().ToString()))
                {
                    if (!pll.IsValidEmail(txtbxBCCEmail.Text.Trim().ToString()))
                    {
                        Status = false;
                        statusFlag++;
                        txtbxBCCEmail.Focus();
                        AppStatus("Check email address. Example: \"example@domain.com\".");
                    }
                }
                else if (!string.IsNullOrEmpty(txtbxReplyToEmail.Text.Trim().ToString()))
                {
                    if (!pll.IsValidEmail(txtbxReplyToEmail.Text.Trim().ToString()))
                    {
                        Status = false;
                        statusFlag++;
                        txtbxReplyToEmail.Focus();
                        AppStatus("Check email address. Example: \"example@domain.com\".");
                    }
                }


                if (statusFlag == 0)
                {
                    if (pll.IsValidEmail(txtbxFromEmail.Text.Trim().ToString()))
                    {
                        Status = false;
                        txtbxFromEmail.Focus();
                        AppStatus("Check email address. Example: \"example\" @ \"Select Server\".");
                    }
                    else
                    {
                        Status = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to check validity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void SendEmail()
        {
            try
            {
                // Basic requirement for send an email
                string receiverEmail = txtbxToEmail.Text.Trim().ToLower().ToString();
                string senderEmail = txtbxFromEmail.Text.Trim().ToLower().ToString() + "@" + cmbbxSMTP.SelectedItem;
                string senderPassword = txtbxPasswordFromEmail.Text.Trim().ToString();
                int portNumber = 587;
                string mailSubject = txtbxEmailSubject.Text.Trim().ToString();
                string mailBody = txtbxEmailBody.Text.Trim().ToString();
                string mailAttachment = txtbxEmailAttachment.Text.Trim().ToString();
                string smtpServer = string.Empty;

                // Advance requirement for send an email
                string ccEmail = txtbxCCEmail.Text.Trim().ToLower().ToString();
                string bccEmail = txtbxBCCEmail.Text.Trim().ToLower().ToString();
                string replyToEmail = txtbxReplyToEmail.Text.Trim().ToLower().ToString();

                // Ready a mail to send
                MailMessage mail = new MailMessage(senderEmail, receiverEmail, mailSubject, mailBody);
                mail.To.Add(receiverEmail);
                mail.IsBodyHtml = true;

                // Set header
                mail.Headers.Add("Notification-To", receiverEmail);

                // Set priority
                if (cmbbxPriority.SelectedIndex == 0)
                {
                    mail.Priority = MailPriority.High;
                }
                else if (cmbbxPriority.SelectedIndex == 2)
                {
                    mail.Priority = MailPriority.Low;
                }
                else
                {
                    mail.Priority = MailPriority.Normal;
                }

                // Add carbon copy (CC) or blind carbon copy (BCC) in the email.
                if (!string.IsNullOrEmpty(ccEmail))
                {
                    mail.CC.Add(ccEmail);
                }
                else if (!string.IsNullOrEmpty(bccEmail))
                {
                    mail.Bcc.Add(bccEmail);
                }

                // Set the email address to receive reply mail
                if (!string.IsNullOrEmpty(replyToEmail))
                {
                    mail.ReplyToList.Add(new MailAddress(replyToEmail));
                }

                // Set the email address to receive delivery report
                //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

                // Set attachment
                if (!string.IsNullOrEmpty(mailAttachment))
                {
                    mail.Attachments.Add(new Attachment(mailAttachment));
                }

                // Set SMTP (Simple Mail Transfer Protocol) server
                if (cmbbxSMTP.SelectedIndex == 1)
                {
                    smtpServer = "smtp.mail.yahoo.com";
                }
                else if (cmbbxSMTP.SelectedIndex == 2)
                {
                    smtpServer = "smtp.live.com";
                }
                else
                {
                    smtpServer = "smtp.gmail.com";
                }

                // Sent Email
                SmtpClient smtpClient = new SmtpClient(smtpServer);
                smtpClient.Port = portNumber;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.Send(mail);
                toolStripProgressBar.Increment(100);

                AppStatus("Email Sended.");
                MessageBox.Show("Email has been Sent!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
