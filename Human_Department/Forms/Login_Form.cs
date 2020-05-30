using Human_Department.Forms;
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
    //форма входа в систему
    //проверяються списки всех членов програмы(соискатели, работники, директор)
    //если данные имени фамилии и пароля совпадают то открываеться 
    //соответствующая форма
    public partial class Login_Form : Form
    {
        Department dep;
        public Login_Form()
        {
            InitializeComponent();
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

        private void Login_Button_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (this.Login.Text == "")
            {
                this.Login.BackColor = Color.Red;
                check = false;
            }
            else
            {
                this.Login.BackColor = Color.Turquoise;
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
            if (check)
            {
                string login = this.Login.Text;
                string password = this.Password.Text;
                if (dep.Director != null)
                {
                    if (((dep.Director.First_Name + " " + dep.Director.Second_Name) == login ||
                     (dep.Director.Second_Name + " " + dep.Director.First_Name) == login) &&
                     dep.Director.Password == password)
                    {
                        Director_App DIR = new Director_App();
                        DIR.Show();
                        this.Close();
                        return;
                    }
                }
                
                if (dep.Employees.Count() != 0)
                {
                    List<Employee> employees = new List<Employee>(dep.Employees.Where(x =>
                     ((x.First_Name + " " + x.Second_Name) == login ||
                     (x.Second_Name + " " + x.First_Name) == login) &&
                     x.Password == password));
                    if (employees.Count() != 0)
                    {
                        Employee_App EMP = new Employee_App(employees[0]);
                        EMP.Show();
                        this.Close();
                        return;
                    }
                }
                if (dep.Job_Seekers.Count() != 0)
                {
                    List<Job_Seeker> JSeeker = new List<Job_Seeker>(dep.Job_Seekers.Where(x =>
                     ((x.First_Name + " " + x.Second_Name) == login ||
                     (x.Second_Name + " " + x.First_Name) == login) &&
                     x.Password == password));
                    if (JSeeker.Count() != 0)
                    {
                        Job_Seeker_App JS = new Job_Seeker_App(JSeeker[0]);
                        JS.Show();
                        this.Close();
                        return;
                    }
                }
                var res = MessageBox.Show("Your Login or password is not correct!");
                return;
            }
        }
    }
}
