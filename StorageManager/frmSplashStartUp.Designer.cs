namespace StorageManager
{
    partial class frmSplashStartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashStartUp));
            this.lblNewStatusInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewStatusInfo
            // 
            this.lblNewStatusInfo.AutoSize = true;
            this.lblNewStatusInfo.Location = new System.Drawing.Point(36, 469);
            this.lblNewStatusInfo.Name = "lblNewStatusInfo";
            this.lblNewStatusInfo.Size = new System.Drawing.Size(226, 24);
            this.lblNewStatusInfo.TabIndex = 0;
            this.lblNewStatusInfo.Text = "程序开始启动......";
            // 
            // frmSplashStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 554);
            this.Controls.Add(this.lblNewStatusInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashStartUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashStartUp";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewStatusInfo;



    }
}