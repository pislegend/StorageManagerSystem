namespace StorageManager
{
    partial class frmCrkmanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrkmanage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpCz = new System.Windows.Forms.GroupBox();
            this.btnRk = new System.Windows.Forms.Button();
            this.btnCk = new System.Windows.Forms.Button();
            this.grpSr = new System.Windows.Forms.GroupBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.dtpCz = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtById = new System.Windows.Forms.TextBox();
            this.lblById = new System.Windows.Forms.Label();
            this.btnScanner = new System.Windows.Forms.Button();
            this.grpByxi = new System.Windows.Forms.GroupBox();
            this.dgvByCrkInfo = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColById = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCzUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCzTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColByInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCz.SuspendLayout();
            this.grpSr.SuspendLayout();
            this.grpByxi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByCrkInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2010, 914);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpCz);
            this.tabPage1.Controls.Add(this.grpSr);
            this.tabPage1.Controls.Add(this.grpByxi);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(1994, 867);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "填写出入库单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpCz
            // 
            this.grpCz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCz.AutoSize = true;
            this.grpCz.Controls.Add(this.btnRk);
            this.grpCz.Controls.Add(this.btnCk);
            this.grpCz.Location = new System.Drawing.Point(1250, 6);
            this.grpCz.Name = "grpCz";
            this.grpCz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCz.Size = new System.Drawing.Size(732, 216);
            this.grpCz.TabIndex = 3;
            this.grpCz.TabStop = false;
            // 
            // btnRk
            // 
            this.btnRk.Image = ((System.Drawing.Image)(resources.GetObject("btnRk.Image")));
            this.btnRk.Location = new System.Drawing.Point(33, 50);
            this.btnRk.Name = "btnRk";
            this.btnRk.Size = new System.Drawing.Size(194, 51);
            this.btnRk.TabIndex = 17;
            this.btnRk.Text = "请点击入库";
            this.btnRk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRk.UseVisualStyleBackColor = true;
            // 
            // btnCk
            // 
            this.btnCk.Image = ((System.Drawing.Image)(resources.GetObject("btnCk.Image")));
            this.btnCk.Location = new System.Drawing.Point(33, 131);
            this.btnCk.Name = "btnCk";
            this.btnCk.Size = new System.Drawing.Size(194, 51);
            this.btnCk.TabIndex = 16;
            this.btnCk.Text = "请点击出库";
            this.btnCk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCk.UseVisualStyleBackColor = true;
            // 
            // grpSr
            // 
            this.grpSr.AutoSize = true;
            this.grpSr.Controls.Add(this.btnManual);
            this.grpSr.Controls.Add(this.dtpCz);
            this.grpSr.Controls.Add(this.label1);
            this.grpSr.Controls.Add(this.txtById);
            this.grpSr.Controls.Add(this.lblById);
            this.grpSr.Controls.Add(this.btnScanner);
            this.grpSr.Location = new System.Drawing.Point(6, 6);
            this.grpSr.Name = "grpSr";
            this.grpSr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpSr.Size = new System.Drawing.Size(1225, 216);
            this.grpSr.TabIndex = 2;
            this.grpSr.TabStop = false;
            this.grpSr.Text = "输入";
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManual.Location = new System.Drawing.Point(407, 109);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(284, 73);
            this.btnManual.TabIndex = 19;
            this.btnManual.Text = "请手动输入";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // dtpCz
            // 
            this.dtpCz.Location = new System.Drawing.Point(934, 30);
            this.dtpCz.Name = "dtpCz";
            this.dtpCz.Size = new System.Drawing.Size(240, 35);
            this.dtpCz.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "出入库日期";
            // 
            // txtById
            // 
            this.txtById.Enabled = false;
            this.txtById.Location = new System.Drawing.Point(238, 34);
            this.txtById.Name = "txtById";
            this.txtById.Size = new System.Drawing.Size(349, 35);
            this.txtById.TabIndex = 14;
            this.txtById.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtById_KeyDown);
            // 
            // lblById
            // 
            this.lblById.AutoSize = true;
            this.lblById.Location = new System.Drawing.Point(49, 37);
            this.lblById.Name = "lblById";
            this.lblById.Size = new System.Drawing.Size(154, 24);
            this.lblById.TabIndex = 13;
            this.lblById.Text = "备件仪表编号";
            // 
            // btnScanner
            // 
            this.btnScanner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnScanner.Location = new System.Drawing.Point(53, 109);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(284, 73);
            this.btnScanner.TabIndex = 1;
            this.btnScanner.Text = "请使用扫码器";
            this.btnScanner.UseVisualStyleBackColor = false;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // grpByxi
            // 
            this.grpByxi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpByxi.Controls.Add(this.dgvByCrkInfo);
            this.grpByxi.Location = new System.Drawing.Point(6, 225);
            this.grpByxi.Name = "grpByxi";
            this.grpByxi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpByxi.Size = new System.Drawing.Size(1982, 625);
            this.grpByxi.TabIndex = 0;
            this.grpByxi.TabStop = false;
            this.grpByxi.Text = "备件仪表出入库明细";
            // 
            // dgvByCrkInfo
            // 
            this.dgvByCrkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvByCrkInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvByCrkInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByCrkInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColById,
            this.ColCzUser,
            this.ColCzTime,
            this.ColByInfo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvByCrkInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvByCrkInfo.Location = new System.Drawing.Point(32, 81);
            this.dgvByCrkInfo.Name = "dgvByCrkInfo";
            this.dgvByCrkInfo.RowTemplate.Height = 37;
            this.dgvByCrkInfo.Size = new System.Drawing.Size(1944, 526);
            this.dgvByCrkInfo.TabIndex = 0;
            this.dgvByCrkInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvByCrkInfo_CellDoubleClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "序号";
            this.ColId.Name = "ColId";
            // 
            // ColById
            // 
            this.ColById.HeaderText = "备件仪表编号";
            this.ColById.Name = "ColById";
            // 
            // ColCzUser
            // 
            this.ColCzUser.HeaderText = "操作人信息";
            this.ColCzUser.Name = "ColCzUser";
            // 
            // ColCzTime
            // 
            this.ColCzTime.HeaderText = "操作时间";
            this.ColCzTime.Name = "ColCzTime";
            // 
            // ColByInfo
            // 
            this.ColByInfo.HeaderText = "备件详情（请双击）";
            this.ColByInfo.Name = "ColByInfo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1994, 867);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出入库单查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1988, 861);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(1982, 827);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmCrkmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2010, 914);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrkmanage";
            this.TabText = "备件仪表入库";
            this.Text = "备件仪表出入库";
            this.Load += new System.EventHandler(this.frmRkmanage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpCz.ResumeLayout(false);
            this.grpSr.ResumeLayout(false);
            this.grpSr.PerformLayout();
            this.grpByxi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByCrkInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpByxi;
        private System.Windows.Forms.DataGridView dgvByCrkInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox grpSr;
        public System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.TextBox txtById;
        private System.Windows.Forms.Label lblById;
        private System.Windows.Forms.Button btnRk;
        private System.Windows.Forms.Button btnCk;
        private System.Windows.Forms.DateTimePicker dtpCz;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grpCz;
        public System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColById;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCzUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCzTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColByInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}