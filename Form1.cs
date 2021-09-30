using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ragister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\dairy\ragister\ragister\dairynew.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM register";
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader dr = cmd.ExecuteReader();
        
            cmd.ExecuteNonQuery();
            while (dr.Read())
            {
                MessageBox.Show(dr.GetValue(0).ToString());
                /*
                if (Convert.ToString(textBox1.Text) == Convert.ToString(dr.GetValue(0)) && textBox2.Text == dr.GetValue(1).ToString())
                {
                    MessageBox.Show("done");
                }
                else
                {
                    MessageBox.Show("not");
                }
              * */
            }

            con.Close();
   
           /* string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sony\Documents\login.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string sql = "insert into login values('"+user+"','"+pass+"')";
            SqlDataAdapter da= sql*/
            this.Hide();
            home hm = new home();
            hm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            register rg = new register();
            rg.Show();
        } 
    }
}
