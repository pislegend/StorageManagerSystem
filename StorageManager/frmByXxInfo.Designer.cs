namespace StorageManager
{
    partial class frmByXxInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvXxInfo = new System.Windows.Forms.DataGridView();
            this.ColXx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXxInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 947);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // dgvXxInfo
            // 
            this.dgvXxInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXxInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXxInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColXx,
            this.ColContent});
            this.dgvXxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXxInfo.Location = new System.Drawing.Point(3, 31);
            this.dgvXxInfo.Name = "dgvXxInfo";
            this.dgvXxInfo.RowTemplate.Height = 37;
            this.dgvXxInfo.Size = new System.Drawing.Size(612, 913);
            this.dgvXxInfo.TabIndex = 0;
            // 
            // ColXx
            // 
            this.ColXx.HeaderText = "信息列";
            this.ColXx.Name = "ColXx";
            // 
            // ColContent
            // 
            this.ColContent.HeaderText = "内容";
            this.ColContent.Name = "ColContent";
            // 
            // frmByXxInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 947);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmByXxInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "详细信息";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColXx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContent;
        public System.Windows.Forms.DataGridView dgvXxInfo;
    }
}