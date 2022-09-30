using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logbookLbl_Click(object sender, EventArgs e)
        {

        }

        private void usernametxtB_MouseEnter(object sender, EventArgs e)
        {
            if (usernametxtB.Text == "@gmail.com")
            {
                usernametxtB.Text = String.Empty;
            }
        }

        private void usernametxtB_MouseLeave(object sender, EventArgs e)
        {
            if (usernametxtB.Text == String.Empty)
            {
                usernametxtB.Text = "@gmail.com";
            }
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
