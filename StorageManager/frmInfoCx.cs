using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StorageManager
{
    public partial class frmInfoCx : frmBase
    {
        public static frmInfoCx frminfocx;
        public frmInfoCx()
        {
            InitializeComponent();
            frminfocx = this;
        }

        string ConStr = "server=TANGZHIHU;database=SrorageDB_new;uid=sa;pwd=123;Max Pool Size=20000;";
        SqlConnection conn;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn = new SqlConnection(ConStr);
            conn.Open();
            if (e.KeyChar == 13)
            {
                dataGridView1.DataSource = null;
                if (textBox1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select *from SrorageDB.dbo.BJTable where 序号='" + textBox1.Text + "'", conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    MessageBox.Show("查询完成");
                }
                else
                {
                    MessageBox.Show("请输入查询序号！");
                }
            }
            conn.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void 操作记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoper frmboper = new frmBoper();
            if (frmboper.Visible)
                frmboper.Hide();
            else
                frmboper.StartPosition = FormStartPosition.CenterScreen;
            frmboper.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBmodify frmbmodify = new frmBmodify();
            if (frmbmodify.Visible)
                frmbmodify.Hide();
            else
                frmbmodify.StartPosition = FormStartPosition.CenterScreen;
            frmbmodify.Show();
        }

        public string sqldelete;

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqldelete = "";
            frmDelete frmdelete = new frmDelete();
            if (frmdelete.Visible)
                frmdelete.Hide();
            else
                frmdelete.StartPosition = FormStartPosition.CenterScreen;
            frmdelete.Show();
            sqldelete = "delete from SrorageDB.dbo.BJTable where 序号='" + frmInfoCx.frminfocx.dataGridView1.SelectedRows[0].Cells[0].Value + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConStr);
            conn.Open();
            string sql = "select * from SrorageDB.dbo.BJTable ";
            if (textBox2.Text != "" | textBox3.Text != "" | comboBox1.Text != "" | comboBox2.Text != "" | comboBox3.Text != "" | comboBox4.Text != "")
            {
                if (textBox2.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 部件名称='" + textBox2.Text + "' ";
                    else
                        sql += "where 部件名称='" + textBox2.Text + "' ";
                if (textBox3.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 部件号='" + textBox3.Text + "' ";
                    else
                        sql += "where 部件号='" + textBox3.Text + "'";
                if (comboBox1.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 所属设备='" + comboBox1.Text + "' ";
                    else
                        sql += "where 所属设备='" + comboBox1.Text + "' ";
                if (comboBox2.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 所属科室='" + comboBox2.Text + "' ";
                    else
                        sql += "where 所属科室='" + comboBox2.Text + "'";
                if (comboBox3.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 状态='" + comboBox3.Text + "' ";
                    else
                        sql += "where 状态='" + comboBox3.Text + "' ";
                if (comboBox4.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 在库状态='" + comboBox4.Text + "' ";
                    else
                        sql += "where 在库状态='" + comboBox4.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("查询完成");
                conn.Close();
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn = new SqlConnection(ConStr);
            conn.Open();
            if (e.KeyChar == 13)
            {
                dataGridView2.DataSource = null;
                if (textBox6.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select *from SrorageDB.dbo.YBTools where 序号='" + textBox6.Text + "'", conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    MessageBox.Show("查询完成");
                }
                else
                {
                    MessageBox.Show("请输入查询序号！");
                }
            }
            conn.Close();

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenuStrip2.Show(MousePosition.X, MousePosition.Y);
        }

        private void 出入库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYgoper frmygoper = new frmYgoper();
            if (frmygoper.Visible)
                frmygoper.Hide();
            else
                frmygoper.StartPosition = FormStartPosition.CenterScreen;
            frmygoper.Show();
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmYgmodify frmygmodify = new frmYgmodify();
            if (frmygmodify.Visible)
                frmygmodify.Hide();
            else
                frmygmodify.StartPosition = FormStartPosition.CenterScreen;
            frmygmodify.Show();
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sqldelete = "";
            frmDelete frmdelete = new frmDelete();
            if (frmdelete.Visible)
                frmdelete.Hide();
            else
                frmdelete.StartPosition = FormStartPosition.CenterScreen;
            frmdelete.Show();
            sqldelete = "delete from SrorageDB.dbo.YBTools where 序号='" + frmInfoCx.frminfocx.dataGridView2.SelectedRows[0].Cells[0].Value + "'";
        }

        private void 季度通电测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string no = frmInfoCx.frminfocx.dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            if (no[0] == 'Y')
            {
                frmYibiaotest frmyibiaotest = new frmYibiaotest();
                if (frmyibiaotest.Visible)
                    frmyibiaotest.Hide();
                else
                    frmyibiaotest.StartPosition = FormStartPosition.CenterScreen;
                frmyibiaotest.Show();
            }
            else
            {
                MessageBox.Show("工具无此项测试！");
            }

        }

        private void 校验记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string no = frmInfoCx.frminfocx.dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            if (no[0] == 'Y')
            {
                frmYibiaocheck frmyibiaocheck = new frmYibiaocheck();
                if (frmyibiaocheck.Visible)
                    frmyibiaocheck.Hide();
                else
                    frmyibiaocheck.StartPosition = FormStartPosition.CenterScreen;
                frmyibiaocheck.Show();
            }
            else
            {
                MessageBox.Show("工具无此项测试！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConStr);
            conn.Open();
            string sql = "select * from SrorageDB.dbo.YBTools ";

            if (comboBox8.Text != "" | comboBox7.Text != "")
            {
                if (comboBox8.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 仪表工具名称='" + comboBox8.Text + "' ";
                    else
                        sql += "where 仪表工具名称='" + comboBox8.Text + "' ";
                if (comboBox7.Text != "")
                    if (sql.Contains("where"))
                        sql += "and 在库状态='" + comboBox7.Text + "' ";
                    else
                        sql += "where 在库状态='" + comboBox7.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                MessageBox.Show("查询完成");
                conn.Close();
            }
            else
            {
                MessageBox.Show("请输入查询条件！");
            }

        }



    }
}
