using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentSystem
{
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Student.accdb;
 Persist Security Info=False;";
        }
        int count;
        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from s_info";
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0].ToString());
            }
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            textBox1.Text = d.Tables["s_info"].Rows[0]["s_id"].ToString();
            textBox2.Text = d.Tables["s_info"].Rows[0]["s_name"].ToString();
            textBox3.Text = d.Tables["s_info"].Rows[0]["s_phone"].ToString();
            textBox4.Text = d.Tables["s_info"].Rows[0]["s_address"].ToString();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGrid1.DataSource = dt;
            con.Close();
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int count;
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            if (count > 0)
            {
                count = 0;
                textBox1.Text = d.Tables["s_info"].Rows[0]["s_id"].ToString();
                textBox2.Text = d.Tables["s_info"].Rows[0]["s_name"].ToString();
                textBox3.Text = d.Tables["s_info"].Rows[0]["s_phone"].ToString();
                textBox4.Text = d.Tables["s_info"].Rows[0]["s_address"].ToString();

                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
            }
            else
            {
                if (count == 0)
                    MessageBox.Show("You are already on first record");
            }
           // dataGridView1
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            if (count > 0)
            {
                count--;
                textBox1.Text = d.Tables["s_info"].Rows[count]["s_id"].ToString();
                textBox2.Text = d.Tables["s_info"].Rows[count]["s_name"].ToString();
                textBox3.Text = d.Tables["s_info"].Rows[count]["s_phone"].ToString();
                textBox4.Text = d.Tables["s_info"].Rows[count]["s_address"].ToString();

                dataGridView1.ClearSelection();
                dataGridView1.Rows[count].Selected = true;
            }
            else
            {
                if (count == 0)
                    MessageBox.Show("You are already on first record");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            if (count < d.Tables["s_info"].Rows.Count-1)
            {
                count++;
                textBox1.Text = d.Tables["s_info"].Rows[count]["s_id"].ToString();
                textBox2.Text = d.Tables["s_info"].Rows[count]["s_name"].ToString();
                textBox3.Text = d.Tables["s_info"].Rows[count]["s_phone"].ToString();
                textBox4.Text = d.Tables["s_info"].Rows[count]["s_address"].ToString();

                dataGridView1.ClearSelection();
                dataGridView1.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["s_info"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            if (count < d.Tables["s_info"].Rows.Count - 1)
            {
                count = d.Tables["s_info"].Rows.Count - 1;
                textBox1.Text = d.Tables["s_info"].Rows[count]["s_id"].ToString();
                textBox2.Text = d.Tables["s_info"].Rows[count]["s_name"].ToString();
                textBox3.Text = d.Tables["s_info"].Rows[count]["s_phone"].ToString();
                textBox4.Text = d.Tables["s_info"].Rows[count]["s_address"].ToString();

                dataGridView1.ClearSelection();
                dataGridView1.Rows[count].Selected = true;
            }
            else
            {
                if (count == d.Tables["s_info"].Rows.Count - 1)
                    MessageBox.Show("You are already on Last record");
            }
            con.Close();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from s_info", con);
            DataSet d = new DataSet();
            adap.Fill(d, "s_info");
            e.Graphics.DrawString("STUDENT DATA", new Font("Times New Roman", 60), Brushes.Black, new Point(50, 100));
            int y = 100;
            for (count = 0; count < d.Tables["s_info"].Rows.Count - 1; count++)
            {
                y += 30;
                e.Graphics.DrawString(d.Tables["s_info"].Rows[count]["s_id"].ToString(), new Font("Times New Roman", 12), Brushes.Black, new Point(25, y+=30));
                e.Graphics.DrawString(d.Tables["s_info"].Rows[count]["s_name"].ToString(), new Font("Times New Roman", 12), Brushes.Black, new Point(25, y += 30));
                e.Graphics.DrawString(d.Tables["s_info"].Rows[count]["s_phone"].ToString(), new Font("Times New Roman", 12), Brushes.Black, new Point(25, y += 30));
                e.Graphics.DrawString(d.Tables["s_info"].Rows[count]["s_address"].ToString(), new Font("Times New Roman", 12), Brushes.Black, new Point(25, y += 30));
                e.HasMorePages = true;

                
            }
            con.Close();
            for(int i=1;i<=5;i++)
            {
                e.HasMorePages = true;
            }

            e.HasMorePages = false;
            
         //   e.HasMorePages = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        
    }
}
