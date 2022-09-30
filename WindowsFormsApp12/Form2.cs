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
    
    public partial class Form2 : Form
    {
        BasliqUC basliqUC = new BasliqUC();
        StudentUC studentUC = new StudentUC();

        
        public Form2()
        {
            InitializeComponent();

            basliqUC.Location = new Point(0, 90);
            this.Controls.Add(basliqUC);

            
            List<Student> students = new List<Student>
            {
                new Student
                {
                    No=1,
                    Fullname="Eliyev Sanan Arif",
                    Date="13.03.21",
                },
                new Student
                {
                    No=2,
                    Fullname="Quliyev Kamran Elcin",
                    Date="14.03.21",
                },
                new Student
                {
                    No=3,
                    Fullname="Rzali Huseyn Eli",
                    Date="15.04.21",
                },
                new Student
                {
                    No=4,
                    Fullname="Tehmezli Tural Fazil",
                    Date="16.03.21",
                },
            };

            int y = 150;
            foreach (var s in students)
            {
                StudentUC studentUC = new StudentUC();
                studentUC.Location = new Point(studentUC.Location.X, y);
                studentUC.No = s.No.ToString();
                studentUC.Fullname = s.Fullname.ToString();
                studentUC.Date = s.Date.ToString();
                y += 90;
                this.Controls.Add(studentUC);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dersinmovzusutxtB.Enabled==false)
            {
                dersinmovzusutxtB.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //if (studentUC.Enabled == false)
            //{

            //    studentUC.Enabled = true;
            //}
        }


    }

}
