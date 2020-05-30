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

namespace Human_Department.Forms
{
    public partial class Employee_App : Form
    {
        bool is_changed = false;
        Department dep;
        Employee employee;
        bool close = true;         //проверка на то хочет ли пользователь 
                                   //закончить работу с приложением или 
                                   //продолжить но под новым логином
        public Employee_App(Employee emp)
        {
            InitializeComponent();
            dep = new Department();
            employee = emp;
            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void Employee_App_Load(object sender, EventArgs e)
        {
            this.Employees.Text += " " + dep.Employees.Count() + " employees work at the enterprise.";
            string curr = this.Vacancies.Text;
            this.Vacancies.Text = " ";
            this.Vacancies.Text += dep.Vacancies.Count() + " " + curr;
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you really wont to quit?", "",
                MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    dep.Orders.Add(new Order(employee));
                    is_changed = true;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void Employee_App_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_changed)
            {
                var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        close = true;
                        break;
                    case DialogResult.Yes:
                        dep.Save();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void Employee_App_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close)
            {
                Application.Exit();
            }
        }

        private void About_us_Click(object sender, EventArgs e)
        {
            var show = MessageBox.Show(this.Employees.Text + "\n" + this.Vacancies.Text);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_changed)
            {
                dep.Save();
                is_changed = false;
            }
        }

        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
            if (!close)
            {
                Start_Form F = new Start_Form();
                F.Visible = true;
            }
        }

        private void See_Salary_Click(object sender, EventArgs e)
        {
            Salary_Changes Sal = new Salary_Changes(employee);
            Sal.Show();
        }
    }
}
