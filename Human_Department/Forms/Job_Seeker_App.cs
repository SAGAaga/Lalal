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
    //главная форма соискателя
    public partial class Job_Seeker_App : Form
    {
        bool is_changed = false;        //проверка были ли внесены изменения данных
        Department dep = new Department();
        Job_Seeker JSeeker;
        bool close = true;         //проверка на то хочет ли пользователь 
                                   //закончить работу с приложением или 
                                   //продолжить но под новым логином

        public Job_Seeker_App(Job_Seeker seeker)
        {
            InitializeComponent();
            JSeeker = seeker;
            this.checkedListBox_Vacancies.Items.Clear();
            int size = dep.Vacancies.Select(x => (x.Position + x.Salary).Length).
                OrderBy(x => x).First();
            size += 13;
            size *= 12;
            int res = 0;
            if (this.checkedListBox_Vacancies.Width < size)
            {
                res = size - this.checkedListBox_Vacancies.Width;
            }
            this.checkedListBox_Vacancies.Width += res;
            this.Width += res;
            this.MinimumSize = new Size( this.Width, this.Height);
            var sorted = dep.Vacancies.Where(x=>x.Speciality==JSeeker.Speciality)
                .OrderBy(x => x.Position);
            foreach (var t in sorted)
                this.checkedListBox_Vacancies.Items.
                        Add(t.Position + " с зарплатой:" + t.Salary);
        }

        private void Job_Seeker_App_Load(object sender, EventArgs e)
        {
            this.Employees.Text += " " + dep.Employees.Count()+" employees work at the enterprise.";
            string curr = this.Vacancies.Text;
            this.Vacancies.Text = " ";
            this.Vacancies.Text+=dep.Vacancies.Count()+" "+curr;

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_changed)
            {
                dep.Save();
                is_changed = false;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Job_Seeker_App_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Job_Seeker_App_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(close)
                Application.Exit();
        }

        private void Show_Vacancies_List_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox_Vacancies.Items.Count == 0)
            {
                var error = MessageBox.Show("Sorry, we do not have suitable vacancies(");
                return;
            }
            this.checkedListBox_Vacancies.Visible = true;
            this.Sort_Check.Visible = true;
            this.Submit.Visible = true;
        }

        private void Sort_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort = this.Sort_Check.Text;
            if(sort== "Сортировать по алфавиту")
            {
                this.checkedListBox_Vacancies.Items.Clear();
                var sorted = dep.Vacancies.Where(x => x.Speciality == JSeeker.Speciality)
                    .OrderBy(x => x.Position);
                foreach (var t in sorted)
                    this.checkedListBox_Vacancies.Items.
                            Add(t.Position + " с зарплатой:" + t.Salary);
            }
            else
            {
                this.checkedListBox_Vacancies.Items.Clear();
                var sorted=dep.Vacancies.Where(x => x.Speciality == JSeeker.Speciality)
                    .OrderBy(x => x.Salary);
                foreach (var t in sorted)
                    this.checkedListBox_Vacancies.Items.
                            Add(t.Position + " с зарплатой:" + t.Salary);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            for (int i = 0; i < this.checkedListBox_Vacancies.Items.Count; i++)
            {
                if (this.checkedListBox_Vacancies.GetItemChecked(i))
                {
                    s.Add(this.checkedListBox_Vacancies.
                        GetItemText(this.checkedListBox_Vacancies.Items[i]));
                }
            }
            foreach(var t in s)
            {
                int i = t.IndexOf(" с зарплатой:");
                string pos = "", sal = "";
                for(int j = 0; j < t.Length; j++)
                {
                    if (j < i)
                    {
                        pos += t[j];
                    }
                    else if (j >= i + 13)
                    {
                        sal += t[j];
                    }
                }
                double salary = Convert.ToDouble(sal);
                dep.Orders.Add(new Order(JSeeker, new Vacancy(pos,JSeeker.Speciality, salary)));
                is_changed = true;
            }
            Sort_Check_SelectedIndexChanged(sender, e);
        }


        private void About_Us_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var show = MessageBox.Show(this.Employees.Text + "\n" + this.Vacancies.Text);
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
    }
}
