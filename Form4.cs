using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewLearnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLearnerForm5 addStdF = new AddLearnerForm5();
            addStdF.Show(this); 
        }
    }
}
