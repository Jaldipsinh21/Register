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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\dairy\ragister\ragister\dairynew.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO  register(unm,pass) VALUES('"+textBox1.Text+"','"+textBox2.Text+"') ";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("done");

            this.Hide();
            Form1 lg = new Form1();
            lg.Show();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
