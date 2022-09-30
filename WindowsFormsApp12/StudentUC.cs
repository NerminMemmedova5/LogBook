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
    public partial class StudentUC : UserControl
    {
        public string No
        {
            get
            {
                return noLbl.Text;
            }
            set
            {
                noLbl.Text = value;
            }
        }
        public string Fullname
        {
            get
            {
                return fullnameLbl.Text;
            }
            set
            {
                fullnameLbl.Text = value;
            }
        }
        public string Date
        {
            get
            {
                return dateLbl.Text;
            }
            set
            {
                dateLbl.Text = value;
            }
        }
        public StudentUC()
        {
            InitializeComponent();
        }

        private void greenGradioBtn_CheckedChanged(object sender, EventArgs e)
        {
           
            if(yoxlamaGradioBtn.Enabled==false && sinifGradioBtn.Enabled == false)
            {
                yoxlamaGradioBtn.Enabled = true;
                sinifGradioBtn.Enabled = true;
                
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            if (reyRichtxtB.Enabled == false)
            {
                reyRichtxtB.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (reyRichtxtB.Enabled == true)
            {
                reyRichtxtB.Enabled = false;
            }
        }
    }
}
