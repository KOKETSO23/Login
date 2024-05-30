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
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        public static Form3 form3Instance;
        public Button tbx;
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        public Form1()
        {

            InitializeComponent();

            // Initialize the database connection and command
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database3.mdb");
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your code here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your code here
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("These fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == textBox3.Text)
            {
                try
                {
                    con.Open();
                    String register = "INSERT INTO db_users VALUES('"+textBox1.Text+"','"+textBox2.Text+"' )";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registered", "Good", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Your code here
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here
        }
    }
}

