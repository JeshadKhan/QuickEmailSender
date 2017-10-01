namespace EmailSender
{
    partial class frmFlashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlashScreen));
            this.picbxAnimation = new System.Windows.Forms.PictureBox();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxAnimation
            // 
            this.picbxAnimation.Image = global::EmailSender.Properties.Resources.animation;
            this.picbxAnimation.Location = new System.Drawing.Point(-2, -1);
            this.picbxAnimation.Name = "picbxAnimation";
            this.picbxAnimation.Size = new System.Drawing.Size(430, 240);
            this.picbxAnimation.TabIndex = 0;
            this.picbxAnimation.TabStop = false;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(0, 239);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(427, 23);
            this.progressBarLoading.TabIndex = 1;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Interval = 32;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // frmFlashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 264);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.picbxAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFlashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Screen - Quick Email Sender";
            this.Load += new System.EventHandler(this.frmFlashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxAnimation;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer tmrLoading;
    }
}