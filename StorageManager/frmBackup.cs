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
    public partial class frmBackup : frmBase
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入备份路径！");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("请输入文件名！");
            }
            else
            {
                SqlConnection conn;
                string ConStr = "server=;database=storemanagement;integrated security=SSPI";
                conn = new SqlConnection(ConStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " backup database storemanagement to disk ='" + textBox1.Text.Trim() + "" + textBox3.Text.Trim() + " 'with init";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("备份完成");
                conn.Close();
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog folderbrowserdialog = new FolderBrowserDialog();//初始化openfiledialog对象            
            if (folderbrowserdialog.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = folderbrowserdialog.SelectedPath;
            }
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();//初始化openfiledialog对象 

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {

                textBox2.Text = openfiledialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入还原文件！");
            }
            else
            {
                SqlConnection conn;
                string ConStr = "server=;database=storemanagement;integrated security=SSPI";
                conn = new SqlConnection(ConStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "use master  restore database storemanagement from disk ='" + textBox2.Text.Trim() + "' with  replace ;use beijianguanli";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("还原完成");
                conn.Close();
            }
        }

       
    }
}
