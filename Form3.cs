using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form3 : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;

        public Form3()
        {
            InitializeComponent();

            // Initialize the database connection and command
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database3.mdb");
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();

        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            // Any initialization code for the form can go here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String Login = "SELECT * FROM db_users WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            cmd = new OleDbCommand(Login, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("These fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reader.Read() == true)
            {
                new Form4().ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("user does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            con.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for textBox2 if needed
        }
    }
}

