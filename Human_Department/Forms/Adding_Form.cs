using Human_Department.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Department
{
    //форма создания нового пользователя
    //созданный пользователь зачисляеться в список соискателей 
    //так как самостоятельная регистрация доступна только для них
    public partial class Adding_Form : Form
    {
        Department dep;
        public Adding_Form()
        {
            InitializeComponent();
            this.Close_Label.Top = 0;
            this.Close_Label.Left = this.Width - this.Close_Label.Width;
            dep = new Department();
        }
        private void Close_Label_Click(object sender, EventArgs e)
        {
            Start_Form F = new Start_Form();
            F.Visible = true;
            this.Close();
        }
        private void Close_Label_MouseHover(object sender, EventArgs e)
        {
            Close_Label.ForeColor = Color.FromArgb(250, 0, 0);
        }

        private void Close_Label_MouseLeave(object sender, EventArgs e)
        {
            Close_Label.ForeColor = Color.White;
        }

        Point Current_Point;

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            Current_Point = new Point(e.X, e.Y);
        }
        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Current_Point.X;
                this.Top += e.Y - Current_Point.Y;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (this.Passport_ID.Text == "")
            {
                this.Passport_ID.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Passport_ID.BackColor = Color.Turquoise;
            }
            if (this.First_Name.Text == "")
            {
                this.First_Name.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.First_Name.BackColor = Color.Turquoise;
            }
            if (this.Second_Name.Text == "")
            {
                this.Second_Name.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Second_Name.BackColor = Color.Turquoise;
            }
            if (this.Aducation.Text == "")
            {
                this.Aducation.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Aducation.BackColor = Color.Turquoise;
            }
            if (this.Speciality.Text == "")
            {
                this.Speciality.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Speciality.BackColor = Color.Turquoise;
            }
            if (this.Birthday.Text == "Year_Month_Day")
            {
                this.Birthday.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Birthday.BackColor = Color.Turquoise;
            }
            if (this.Password.Text == "")
            {
                this.Password.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Password.BackColor = Color.Turquoise;
            }
            //Проверка на пустоту полей
            if((dep.Employees.Exists(x=>x.First_Name==this.First_Name.Text &&
            x.Second_Name==this.Second_Name.Text &&
            (x.Password==this.Password.Text || x.Pasport_Id==this.Passport_ID.Text))) ||

            (dep.Job_Seekers.Exists(x => x.First_Name == this.First_Name.Text &&
            x.Second_Name == this.Second_Name.Text &&
            (x.Password == this.Password.Text || x.Pasport_Id == this.Passport_ID.Text))) ||
            
            (dep.Director.First_Name==this.First_Name.Text &&
            dep.Director.Second_Name==this.Second_Name.Text &&
            (dep.Director.Pasport_Id==this.Passport_ID.Text ||
            dep.Director.Password == this.Password.Text)))
            {
                check = false;
                var r = MessageBox.Show("Sorry, but such a user has already existed((!");
            }
            if (check)
            {
                char[] sep = { '.', ',', ':', '-' };
                string Fn = this.First_Name.Text;
                string Sn = this.Second_Name.Text;
                string Num = this.Passport_ID.Text;
                string Adu = this.Aducation.Text;
                string Spec = this.Speciality.Text;
                string Pas = this.Password.Text;
                string[] Birth = this.Birthday.Text.Split(sep);
                if (Birth.Length != 3)
                {
                    this.Birthday.Text = "Year_Month_Day";
                    this.Birthday.BackColor = Color.Red;
                    return;
                }
                DateTime Bithday;
                try
                {
                    Bithday = new DateTime(Convert.ToInt32(Birth[0]),
                        Convert.ToInt32(Birth[1]),
                        Convert.ToInt32(Birth[2]));
                }
                catch (ArgumentOutOfRangeException)
                {
                    this.Birthday.Text = "Year_Month_Day";
                    this.Birthday.BackColor = Color.Red;
                    return;
                }
                dep.Job_Seekers.Add(new Job_Seeker(Fn, Sn, Bithday, Num, Adu, Spec,Pas));
                dep.Save();
                this.Close();
                Start_Form form=new Start_Form();
                form.Visible = true;
            }
        }

        private void Birthday_Enter(object sender, EventArgs e)
        {
            if (this.Birthday.Text == "Year_Month_Day")
            {
                this.Birthday.Text = "";
            }
        }

        private void Birthday_Leave(object sender, EventArgs e)
        {
            if (this.Birthday.Text == "")
            {
                this.Birthday.Text = "Year_Month_Day";
            }
        }
    }
}
