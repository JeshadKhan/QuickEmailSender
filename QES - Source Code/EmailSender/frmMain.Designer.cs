namespace EmailSender
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutEmailSenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxToEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxFromEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPasswordFromEmail = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxEmailSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxSMTP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxEmailAttachment = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxCCEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxBCCEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbxReplyToEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbbxPriority = new System.Windows.Forms.ComboBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tlstrpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtbxEmailBody = new System.Windows.Forms.RichTextBox();
            this.btnUploadAttachment = new System.Windows.Forms.Button();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.grpbxFrom = new System.Windows.Forms.GroupBox();
            this.grpbxTo = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIconMinimizeToTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.grpbxFrom.SuspendLayout();
            this.grpbxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(634, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator3,
            this.minimizeToTrayToolStripMenuItem,
            this.toolStripSeparator7,
            this.restartToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearToolStripMenuItem.Text = "&Clear / Reset";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Visible = false;
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to &Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(160, 6);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on &Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator9,
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutEmailSenderToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewHelpToolStripMenuItem.Text = "&View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // aboutEmailSenderToolStripMenuItem
            // 
            this.aboutEmailSenderToolStripMenuItem.Name = "aboutEmailSenderToolStripMenuItem";
            this.aboutEmailSenderToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aboutEmailSenderToolStripMenuItem.Text = "&About Quick Email Sender";
            this.aboutEmailSenderToolStripMenuItem.Click += new System.EventHandler(this.aboutEmailSenderToolStripMenuItem_Click);
            // 
            // txtbxToEmail
            // 
            this.txtbxToEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxToEmail.Location = new System.Drawing.Point(89, 19);
            this.txtbxToEmail.Name = "txtbxToEmail";
            this.txtbxToEmail.Size = new System.Drawing.Size(240, 20);
            this.txtbxToEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // txtbxFromEmail
            // 
            this.txtbxFromEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFromEmail.Location = new System.Drawing.Point(89, 18);
            this.txtbxFromEmail.Name = "txtbxFromEmail";
            this.txtbxFromEmail.Size = new System.Drawing.Size(140, 20);
            this.txtbxFromEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // txtbxPasswordFromEmail
            // 
            this.txtbxPasswordFromEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPasswordFromEmail.Location = new System.Drawing.Point(89, 45);
            this.txtbxPasswordFromEmail.Name = "txtbxPasswordFromEmail";
            this.txtbxPasswordFromEmail.PasswordChar = '*';
            this.txtbxPasswordFromEmail.Size = new System.Drawing.Size(240, 20);
            this.txtbxPasswordFromEmail.TabIndex = 7;
            this.txtbxPasswordFromEmail.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtbxEmailSubject
            // 
            this.txtbxEmailSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxEmailSubject.Location = new System.Drawing.Point(70, 4);
            this.txtbxEmailSubject.Name = "txtbxEmailSubject";
            this.txtbxEmailSubject.Size = new System.Drawing.Size(200, 20);
            this.txtbxEmailSubject.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "@";
            // 
            // cmbbxSMTP
            // 
            this.cmbbxSMTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSMTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxSMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSMTP.FormattingEnabled = true;
            this.cmbbxSMTP.Items.AddRange(new object[] {
            "gmail.com",
            "yahoo.com",
            "live.com",
            "gmx.com",
            "mail.com"});
            this.cmbbxSMTP.Location = new System.Drawing.Point(251, 17);
            this.cmbbxSMTP.Name = "cmbbxSMTP";
            this.cmbbxSMTP.Size = new System.Drawing.Size(78, 21);
            this.cmbbxSMTP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Attachment";
            // 
            // txtbxEmailAttachment
            // 
            this.txtbxEmailAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxEmailAttachment.Location = new System.Drawing.Point(70, 30);
            this.txtbxEmailAttachment.Name = "txtbxEmailAttachment";
            this.txtbxEmailAttachment.Size = new System.Drawing.Size(143, 20);
            this.txtbxEmailAttachment.TabIndex = 11;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(8, 189);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(263, 39);
            this.btnSendEmail.TabIndex = 14;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CC";
            // 
            // txtbxCCEmail
            // 
            this.txtbxCCEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxCCEmail.Location = new System.Drawing.Point(89, 45);
            this.txtbxCCEmail.Name = "txtbxCCEmail";
            this.txtbxCCEmail.Size = new System.Drawing.Size(240, 20);
            this.txtbxCCEmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "BCC";
            // 
            // txtbxBCCEmail
            // 
            this.txtbxBCCEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxBCCEmail.Location = new System.Drawing.Point(89, 71);
            this.txtbxBCCEmail.Name = "txtbxBCCEmail";
            this.txtbxBCCEmail.Size = new System.Drawing.Size(240, 20);
            this.txtbxBCCEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Reply To";
            // 
            // txtbxReplyToEmail
            // 
            this.txtbxReplyToEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxReplyToEmail.Location = new System.Drawing.Point(89, 97);
            this.txtbxReplyToEmail.Name = "txtbxReplyToEmail";
            this.txtbxReplyToEmail.Size = new System.Drawing.Size(240, 20);
            this.txtbxReplyToEmail.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Priority";
            // 
            // cmbbxPriority
            // 
            this.cmbbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxPriority.FormattingEnabled = true;
            this.cmbbxPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.cmbbxPriority.Location = new System.Drawing.Point(89, 71);
            this.cmbbxPriority.Name = "cmbbxPriority";
            this.cmbbxPriority.Size = new System.Drawing.Size(240, 21);
            this.cmbbxPriority.TabIndex = 8;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.tlstrpStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 262);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(634, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 28;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tlstrpStatusLabel
            // 
            this.tlstrpStatusLabel.Name = "tlstrpStatusLabel";
            this.tlstrpStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.txtbxEmailBody);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txtbxEmailSubject);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.btnUploadAttachment);
            this.pnlData.Controls.Add(this.txtbxEmailAttachment);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.btnSendEmail);
            this.pnlData.Location = new System.Drawing.Point(352, 27);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(275, 228);
            this.pnlData.TabIndex = 29;
            // 
            // txtbxEmailBody
            // 
            this.txtbxEmailBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxEmailBody.Location = new System.Drawing.Point(8, 84);
            this.txtbxEmailBody.Name = "txtbxEmailBody";
            this.txtbxEmailBody.Size = new System.Drawing.Size(262, 99);
            this.txtbxEmailBody.TabIndex = 13;
            this.txtbxEmailBody.Text = "";
            // 
            // btnUploadAttachment
            // 
            this.btnUploadAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAttachment.Image = global::EmailSender.Properties.Resources.icon_upload;
            this.btnUploadAttachment.Location = new System.Drawing.Point(219, 30);
            this.btnUploadAttachment.Name = "btnUploadAttachment";
            this.btnUploadAttachment.Size = new System.Drawing.Size(50, 20);
            this.btnUploadAttachment.TabIndex = 12;
            this.btnUploadAttachment.UseVisualStyleBackColor = true;
            this.btnUploadAttachment.Click += new System.EventHandler(this.btnUploadAttachment_Click);
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.grpbxFrom);
            this.pnlTarget.Controls.Add(this.grpbxTo);
            this.pnlTarget.Location = new System.Drawing.Point(8, 24);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(340, 231);
            this.pnlTarget.TabIndex = 17;
            // 
            // grpbxFrom
            // 
            this.grpbxFrom.Controls.Add(this.label3);
            this.grpbxFrom.Controls.Add(this.label5);
            this.grpbxFrom.Controls.Add(this.cmbbxSMTP);
            this.grpbxFrom.Controls.Add(this.cmbbxPriority);
            this.grpbxFrom.Controls.Add(this.txtbxPasswordFromEmail);
            this.grpbxFrom.Controls.Add(this.label12);
            this.grpbxFrom.Controls.Add(this.label2);
            this.grpbxFrom.Controls.Add(this.txtbxFromEmail);
            this.grpbxFrom.Location = new System.Drawing.Point(3, 131);
            this.grpbxFrom.Name = "grpbxFrom";
            this.grpbxFrom.Size = new System.Drawing.Size(335, 100);
            this.grpbxFrom.TabIndex = 30;
            this.grpbxFrom.TabStop = false;
            this.grpbxFrom.Text = "From";
            // 
            // grpbxTo
            // 
            this.grpbxTo.Controls.Add(this.label1);
            this.grpbxTo.Controls.Add(this.label8);
            this.grpbxTo.Controls.Add(this.txtbxBCCEmail);
            this.grpbxTo.Controls.Add(this.txtbxCCEmail);
            this.grpbxTo.Controls.Add(this.txtbxToEmail);
            this.grpbxTo.Controls.Add(this.label9);
            this.grpbxTo.Controls.Add(this.txtbxReplyToEmail);
            this.grpbxTo.Controls.Add(this.label10);
            this.grpbxTo.Location = new System.Drawing.Point(3, 0);
            this.grpbxTo.Name = "grpbxTo";
            this.grpbxTo.Size = new System.Drawing.Size(335, 125);
            this.grpbxTo.TabIndex = 27;
            this.grpbxTo.TabStop = false;
            this.grpbxTo.Text = "To";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Attachment - Quick Email Sender";
            // 
            // notifyIconMinimizeToTray
            // 
            this.notifyIconMinimizeToTray.BalloonTipText = "Successfully minimize to tray.";
            this.notifyIconMinimizeToTray.BalloonTipTitle = "Quick Email Sender";
            this.notifyIconMinimizeToTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMinimizeToTray.Icon")));
            this.notifyIconMinimizeToTray.Visible = true;
            this.notifyIconMinimizeToTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMinimizeToTray_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 284);
            this.Controls.Add(this.pnlTarget);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.pnlData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Email Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTarget.ResumeLayout(false);
            this.grpbxFrom.ResumeLayout(false);
            this.grpbxFrom.PerformLayout();
            this.grpbxTo.ResumeLayout(false);
            this.grpbxTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutEmailSenderToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxToEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxFromEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtbxPasswordFromEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxEmailSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUploadAttachment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxEmailAttachment;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxCCEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxBCCEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbxReplyToEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxPriority;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel tlstrpStatusLabel;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.RichTextBox txtbxEmailBody;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox grpbxTo;
        private System.Windows.Forms.GroupBox grpbxFrom;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.NotifyIcon notifyIconMinimizeToTray;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

