namespace StorageManager
{
    partial class frmStorageMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStorageMain));
            this.mnsStorageMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.登录LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsrslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsrslblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsrbNav = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrbCrk = new System.Windows.Forms.ToolStripButton();
            this.tsrbInfocx = new System.Windows.Forms.ToolStripButton();
            this.tsrbBym = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrbTimeTag = new System.Windows.Forms.ToolStripLabel();
            this.tsrbTime = new System.Windows.Forms.ToolStripLabel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnsStorageMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsStorageMain
            // 
            this.mnsStorageMain.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mnsStorageMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mnsStorageMain.Location = new System.Drawing.Point(0, 0);
            this.mnsStorageMain.Name = "mnsStorageMain";
            this.mnsStorageMain.Size = new System.Drawing.Size(1987, 39);
            this.mnsStorageMain.TabIndex = 0;
            this.mnsStorageMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录LToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 35);
            this.toolStripMenuItem1.Text = "系统(S)";
            // 
            // 登录LToolStripMenuItem
            // 
            this.登录LToolStripMenuItem.Name = "登录LToolStripMenuItem";
            this.登录LToolStripMenuItem.Size = new System.Drawing.Size(164, 36);
            this.登录LToolStripMenuItem.Text = "登录(L)";
            this.登录LToolStripMenuItem.Click += new System.EventHandler(this.登录LToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(164, 36);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 35);
            this.toolStripMenuItem2.Text = "窗口(W)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 35);
            this.toolStripMenuItem3.Text = "数据维护(D)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(109, 35);
            this.toolStripMenuItem4.Text = "帮助(H)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsrslblTime,
            this.toolStripSeparator3,
            this.toolStripStatusLabel3,
            this.tsrslblUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 771);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1987, 36);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 31);
            this.toolStripStatusLabel1.Text = "当前时间:";
            // 
            // tsrslblTime
            // 
            this.tsrslblTime.Name = "tsrslblTime";
            this.tsrslblTime.Size = new System.Drawing.Size(257, 31);
            this.tsrslblTime.Text = "toolStripStatusLabel2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel3.Text = "当前用户：";
            // 
            // tsrslblUserName
            // 
            this.tsrslblUserName.Name = "tsrslblUserName";
            this.tsrslblUserName.Size = new System.Drawing.Size(128, 31);
            this.tsrslblUserName.Text = "科室+用户";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrbNav,
            this.toolStripSeparator4,
            this.tsrbCrk,
            this.tsrbInfocx,
            this.tsrbBym,
            this.toolStripSeparator1,
            this.tsrbExit,
            this.toolStripSeparator2,
            this.tsrbTimeTag,
            this.tsrbTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1987, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsrbNav
            // 
            this.tsrbNav.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbNav.Image = ((System.Drawing.Image)(resources.GetObject("tsrbNav.Image")));
            this.tsrbNav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrbNav.Name = "tsrbNav";
            this.tsrbNav.Size = new System.Drawing.Size(122, 36);
            this.tsrbNav.Text = "导航条";
            this.tsrbNav.Click += new System.EventHandler(this.tsrbNav_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsrbCrk
            // 
            this.tsrbCrk.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbCrk.Image = ((System.Drawing.Image)(resources.GetObject("tsrbCrk.Image")));
            this.tsrbCrk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrbCrk.Name = "tsrbCrk";
            this.tsrbCrk.Size = new System.Drawing.Size(218, 36);
            this.tsrbCrk.Text = "备件仪表出入库";
            this.tsrbCrk.Click += new System.EventHandler(this.tsrbCrk_Click);
            // 
            // tsrbInfocx
            // 
            this.tsrbInfocx.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbInfocx.Image = ((System.Drawing.Image)(resources.GetObject("tsrbInfocx.Image")));
            this.tsrbInfocx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrbInfocx.Name = "tsrbInfocx";
            this.tsrbInfocx.Size = new System.Drawing.Size(266, 36);
            this.tsrbInfocx.Text = "备件仪表信息与查询";
            this.tsrbInfocx.Click += new System.EventHandler(this.tsrbInfocx_Click);
            // 
            // tsrbBym
            // 
            this.tsrbBym.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbBym.Image = ((System.Drawing.Image)(resources.GetObject("tsrbBym.Image")));
            this.tsrbBym.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrbBym.Name = "tsrbBym";
            this.tsrbBym.Size = new System.Drawing.Size(242, 36);
            this.tsrbBym.Text = "备件仪表综合管理";
            this.tsrbBym.Click += new System.EventHandler(this.tsrbBym_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsrbExit
            // 
            this.tsrbExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsrbExit.Image")));
            this.tsrbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrbExit.Name = "tsrbExit";
            this.tsrbExit.Size = new System.Drawing.Size(146, 36);
            this.tsrbExit.Text = "退出系统";
            this.tsrbExit.Click += new System.EventHandler(this.tsrbExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsrbTimeTag
            // 
            this.tsrbTimeTag.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrbTimeTag.Name = "tsrbTimeTag";
            this.tsrbTimeTag.Size = new System.Drawing.Size(86, 36);
            this.tsrbTimeTag.Text = "时间：";
            // 
            // tsrbTime
            // 
            this.tsrbTime.ForeColor = System.Drawing.Color.Red;
            this.tsrbTime.Name = "tsrbTime";
            this.tsrbTime.Size = new System.Drawing.Size(186, 36);
            this.tsrbTime.Text = "toolStripLabel2";
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Location = new System.Drawing.Point(1519, 388);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(200, 100);
            this.dockPanel1.TabIndex = 8;
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 78);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(1987, 693);
            this.dockPanel.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStorageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1987, 807);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnsStorageMain);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmStorageMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "湖北空管分局 技术保障部备件仪表管理系统";
            this.Text = "湖北空管分局 技术保障部备件仪表管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsStorageMain.ResumeLayout(false);
            this.mnsStorageMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsStorageMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsrslblTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsrbNav;
        private System.Windows.Forms.ToolStripButton tsrbCrk;
        private System.Windows.Forms.ToolStripButton tsrbBym;
        private System.Windows.Forms.ToolStripButton tsrbInfocx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsrbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsrbTimeTag;
        private System.Windows.Forms.ToolStripLabel tsrbTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 登录LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        public System.Windows.Forms.ToolStripStatusLabel tsrslblUserName;
    }
}

