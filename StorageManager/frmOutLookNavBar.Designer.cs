namespace StorageManager
{
    partial class frmOutLookNavBar
    {

        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutLookNavBar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 758);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "management_pencil_256px.png");
            this.imageList1.Images.SetKeyName(1, "management_zoom_256px.png");
            this.imageList1.Images.SetKeyName(2, "management_gear_256px.png");
            // 
            // frmOutLookNavBar
            // 
            this.ClientSize = new System.Drawing.Size(274, 758);
            this.Controls.Add(this.panel1);
            this.Name = "frmOutLookNavBar";
            this.ResumeLayout(false);

        }
    }
}