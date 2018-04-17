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
using System.Data.OleDb;

namespace StorageManager
{
    public partial class frmByManage : frmBase
    {
        public frmByManage()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
                this.dataGridView1.DataSource = dt;
                textBox1.Text = fileName;

            }
        }

        DataTable dt = new DataTable();
        private void bind(string fileName)
        {

            //      string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            //          "Data Source=" + fileName + ";" +
            //          "Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'";
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" +
                "data source=" + fileName + ";" +
                "Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *  FROM [Sheet1$]", strConn);

            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];

            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());
            }
        }

        //string ConStr = "server=;database=storemanagement;integrated security=SSPI";
        string ConStr = "server=TANGZHIHU;database=SrorageDB_new;uid=sa;pwd=123;Max Pool Size=20000;";
        SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                if (dataGridView1.Rows.Count > 0 & dt != null)
                {
                    DataRow dr = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        //            SqlCommand cmd = new SqlCommand("select *from storemanagement.dbo.Bujianinfor_1", conn);
                        //            SqlDataAdapter sda = new SqlDataAdapter();
                        //           sda.SelectCommand = cmd;
                        //            DataSet ds2 = new DataSet();
                        //            sda.Fill(ds2);



                        // string a1 = dataGridView20.Rows[0].Cells[0].Value.ToString();
                        // string b1 = dataGridView20.Rows[0].Cells[1].Value.ToString();
                        // if (a1 == dr["序号"].ToString() & b1 == dr["部件名称"].ToString())
                        //      {
                        //     MessageBox.Show("有重复项！");
                        //     break;
                        //    }
                        //   else 
                        //     {
                        insertToSql(dr);
                        //     }

                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                    dt = null;
                    textBox1.Text = null;
                }
                else
                {
                    MessageBox.Show("没有数据！");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的部件数据格式！");
            }
        }

        private void insertToSql(DataRow dr)
        {
            //   for (int i = 0; i < dr.ItemArray.Length; i++)
            //   {
            //       List<String> list = new List<String>();
            //        list.Add(dr[i].ToString());
            //        var j = list.ToArray();
            //     }
            //excel表中的列名和数据库中的列名一定要对应  
            string xu = dr[0].ToString();
            string buname = dr[1].ToString();
            string buno = dr["部件号"].ToString();
            string xuno = dr["序列号"].ToString();
            string shebei = dr["所属设备"].ToString();
            string keshi = dr["所属科室"].ToString();
            string zhuangtai = dr["状态"].ToString();
            string zaiku = dr["在库状态"].ToString();
            string zeren = dr["责任人"].ToString();
            string guanli = dr["仓库管理员"].ToString();
            //string sql = "insert into storemanagement.dbo.Bujianinfor_1 values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "','" + zeren + "','" + guanli + "')";
            string sql = "insert into SrorageDB_new.dbo.BJTable values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "','" + zeren + "','" + guanli + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "")
            {
                conn = new SqlConnection(ConStr);
                conn.Open();
                //string sql = "insert into storemanagement.dbo.Bujianinfor_1 values('" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "', '" + comboBox1.Text.Trim() + "','" + comboBox2.Text.Trim() + "', '" + comboBox3.Text.Trim() + "','" + comboBox4.Text.Trim() + "','" + comboBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                string sql = "insert into SrorageDB_new.dbo.BJTable values('" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "', '" + comboBox1.Text.Trim() + "','" + comboBox2.Text.Trim() + "', '" + comboBox3.Text.Trim() + "','" + comboBox4.Text.Trim() + "','" + comboBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("导入成功！");
                conn.Close();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
            }
            else
            {
                MessageBox.Show("请输入部件信息！");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBoper frmboper = new frmBoper();
            if (frmboper.Visible)
                frmboper.Hide();
            else
                frmboper.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "" & textBox8.Text != "" & textBox10.Text != "")
            {
                conn = new SqlConnection(ConStr);
                conn.Open();
                string sql = "insert into SrorageDB_new.dbo.BYTools values('" + textBox11.Text.Trim() + "','" + textBox8.Text.Trim() + "','" + textBox10.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "', '" + comboBox10.Text.Trim() + "','" + comboBox8.Text.Trim() + "', '" + dateTimePicker2.Text.Trim() + "','" + dateTimePicker3.Text.Trim() + "','" + comboBox9.Text.Trim() + "','" + comboBox6.Text.Trim() + "','" + comboBox7.Text.Trim() + "','" + textBox7.Text.Trim() + "')";         
                //string sql = "insert into storemanagement.dbo.Yigonginfor_1 values('" + textBox11.Text.Trim() + "','" + textBox8.Text.Trim() + "','" + textBox10.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "', '" + comboBox10.Text.Trim() + "','" + comboBox8.Text.Trim() + "', '" + dateTimePicker2.Text.Trim() + "','" + dateTimePicker3.Text.Trim() + "','" + comboBox9.Text.Trim() + "','" + comboBox6.Text.Trim() + "','" + comboBox7.Text.Trim() + "','" + textBox7.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("导入成功！");
                conn.Close();
                textBox11.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
            }
            else
            {
                MessageBox.Show("请输入仪表/工具信息！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "" & textBox14.Text != "" & textBox15.Text != "")
            {
                conn = new SqlConnection(ConStr);
                conn.Open();
                string sql = "insert into SrorageDB_new.dbo.HCTable values('" + textBox13.Text.Trim() + "','" + textBox14.Text.Trim() + "','" + textBox15.Text.Trim() + "','" + textBox9.Text.Trim() + "', '" + comboBox15.Text.Trim() + "', '" + dateTimePicker2.Text.Trim() + "','" + textBox17.Text.Trim() + "','" + textBox18.Text.Trim() + "')";               
                //string sql = "insert into storemanagement.dbo.Haocaiinfor_1 values('" + textBox13.Text.Trim() + "','" + textBox14.Text.Trim() + "','" + textBox15.Text.Trim() + "','" + textBox9.Text.Trim() + "', '" + comboBox15.Text.Trim() + "', '" + dateTimePicker2.Text.Trim() + "','" + textBox17.Text.Trim() + "','" + textBox18.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("导入成功！");
                conn.Close();
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
            }
            else
            {
                MessageBox.Show("请输入耗材信息！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();
                if (dataGridView2.Rows.Count > 0 & dt != null)
                {
                    DataRow dr = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        insertToSql1(dr);
                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                    dt = null;
                    textBox12.Text = null;
                }
                else
                {
                    MessageBox.Show("没有数据！");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的仪表\\工具数据格式！");
            }
        }
        private void insertToSql1(DataRow dr)
        {

            //excel表中的列名和数据库中的列名一定要对应  
            string xu = dr[0].ToString();
            string buname = dr[1].ToString();
            string buno = dr[2].ToString();
            DateTime xuno = Convert.ToDateTime(dr[3].ToString());
            string shebei = dr[4].ToString();
            string keshi = dr[5].ToString();
            DateTime zhuangtai = Convert.ToDateTime(dr[6].ToString());
            DateTime zaiku = Convert.ToDateTime(dr[7].ToString());
            string zeren = dr[8].ToString();
            string guanli = dr[9].ToString();
            string guanli0 = dr[10].ToString();
            string guanli1 = dr[11].ToString();
            string sql = "insert into SrorageDB_new.dbo.YBTools values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "','" + zeren + "','" + guanli + "','" + guanli0 + "','" + guanli1 + "')";            
            //string sql = "insert into storemanagement.dbo.Yigonginfor_1 values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "','" + zeren + "','" + guanli + "','" + guanli0 + "','" + guanli1 + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void textBox12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
                this.dataGridView2.DataSource = dt;
                textBox12.Text = fileName;
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenuStrip2.Show(MousePosition.X, MousePosition.Y);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmYgoper frmygoper = new frmYgoper();
            if (frmygoper.Visible)
                frmygoper.Hide();
            else
                frmygoper.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();
                if (dataGridView3.Rows.Count > 0 & dt != null)
                {
                    DataRow dr = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        insertToSql2(dr);
                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                    dt = null;
                    textBox16.Text = null;
                }
                else
                {
                    MessageBox.Show("没有数据！");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的耗材数据格式！");
            }

        }
        private void insertToSql2(DataRow dr)
        {

            //excel表中的列名和数据库中的列名一定要对应  
            string xu = dr[0].ToString();
            string buname = dr[1].ToString();
            string buno = dr[2].ToString();
            string xuno = dr[3].ToString();
            string shebei = dr[4].ToString();
            string keshi = dr[5].ToString();
            string zhuangtai = dr[6].ToString();
            string zaiku = dr[7].ToString();
            string sql = "insert into SrorageDB_new.dbo.HCTable values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "')";           
            //string sql = "insert into storemanagement.dbo.Haocaiinfor_1 values('" + xu + "','" + buname + "','" + buno + "','" + xuno + "', '" + shebei + "','" + keshi + "', '" + zhuangtai + "','" + zaiku + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void textBox16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
                this.dataGridView3.DataSource = dt;
                textBox16.Text = fileName;
            }
        }

        private void 耗材使用情况记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHcuse frmhcuse = new frmHcuse();
            if (frmhcuse.Visible)
                frmhcuse.Hide();
            else
                frmhcuse.Show();

        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip3.Show(MousePosition.X, MousePosition.Y);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
                this.dataGridView1.DataSource = dt;
                textBox1.Text = fileName;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                if (dataGridView1.Rows.Count > 0 & dt != null)
                {
                    DataRow dr = null;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        //            SqlCommand cmd = new SqlCommand("select *from storemanagement.dbo.Bujianinfor_1", conn);
                        //            SqlDataAdapter sda = new SqlDataAdapter();
                        //           sda.SelectCommand = cmd;
                        //            DataSet ds2 = new DataSet();
                        //            sda.Fill(ds2);



                        // string a1 = dataGridView20.Rows[0].Cells[0].Value.ToString();
                        // string b1 = dataGridView20.Rows[0].Cells[1].Value.ToString();
                        // if (a1 == dr["序号"].ToString() & b1 == dr["部件名称"].ToString())
                        //      {
                        //     MessageBox.Show("有重复项！");
                        //     break;
                        //    }
                        //   else 
                        //     {
                        insertToSql(dr);
                        //     }

                    }
                    conn.Close();
                    MessageBox.Show("导入成功！");
                    dt = null;
                    textBox1.Text = null;
                }
                else
                {
                    MessageBox.Show("没有数据！");
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的部件数据格式！");
            }
        }


        
    }
}
