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
    public partial class Director_App : Form
    {
        Department dep;
        bool close = true;
        bool is_changed = false;
        public Director_App()
        {
            InitializeComponent();
            dep = new Department();
            //заполнение списка сотрудников
            var add = dep.Employees.OrderBy(x => x.Second_Name).ThenBy(x => x.First_Name).
                Select(x => x.Second_Name + " " + x.First_Name + " " +
                x.Position + " Salary: " + x.Salary);
            foreach(var ad in add)
            {
                this.Employees_List.Items.Add(ad);
            }
            //Заполнение списка работников
            add = dep.Job_Seekers.OrderBy(x => x.Second_Name).ThenBy(x => x.First_Name).
                Select(x => x.Second_Name + " " + x.First_Name + " " +
                x.Speciality);
            foreach (var ad in add)
            {
                this.Job_Seekers_List.Items.Add(ad);
            }
            // Заполнение списка меющихся вакансий
            add = dep.Vacancies.OrderBy(x => x.Speciality).
                Select(x => x.Speciality + " " + x.Position +" Salary: "+
                x.Salary);
            foreach (var ad in add)
            {
                this.Vacances_List.Items.Add(ad);
            }
            // Заполнение списка приказов
            //разелим приказы на приказы об увольнении и зачислении на работу
            //add1 приказы об зачислении на работу
            var add1 = dep.Orders.Where(x => x.Employee == null && x.Is_Cheked == false).                
                OrderBy(x => x.Seeker.Second_Name).
                Select(x => x.Seeker.Second_Name + " " + x.Seeker.First_Name + " Position: " +
                x.Vacancy.Position + " Salary: " + x.Vacancy.Salary);
            foreach (var adding in add1)
            {
                this.Orders_for_Hiring_List.Items.Add(adding);
            }
            //add2 приказы об увольнении
            var add2 = dep.Orders.Where(x => x.Seeker == null && x.Is_Cheked == false).
                OrderBy(x => x.Employee.Second_Name).
                Select(x => x.Employee.Second_Name + " " + x.Employee.First_Name + " Position: " +
                x.Vacancy.Position + " Salary: " + x.Vacancy.Salary);
            foreach (var adding in add2)
            {
                this.Orders_for_quiting_List.Items.Add(adding);
            }
        }

        private void About_us_Click(object sender, EventArgs e)
        {
            var show = MessageBox.Show("Currently " + dep.Employees.Count() +
                " employees work at the enterprise.\n" +
                dep.Vacancies.Count() +
                " vacancies currently available");
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
        private void Director_App_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close)
            {
                Application.Exit();
            }
        }

        private void Director_App_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            for (int i = 0; i < this.Employees_List.Items.Count; i++)
            {
                if (this.Employees_List.GetItemChecked(i))
                {
                    s.Add(this.Employees_List.
                        GetItemText(this.Employees_List.Items[i]));
                }
            }
            List<Employee> emp = new List<Employee>();
            foreach(var t in s)
            {
                string[] mas = t.Split(' ');
                emp.Add(dep.Employees.Where(x => x.Second_Name == mas[0] &&
                x.First_Name == mas[1] && x.Position == mas[2] &&
                x.Salary == Convert.ToDouble(mas[4])).First());
            }

            foreach (var Del in emp)
            {
                var res = MessageBox.Show($"Dismiss {Del.First_Name} {Del.Second_Name} ?",
                    "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    dep.Vacancies.Add(new Vacancy(Del.Position, Del.Speciality, Del.Salary)); 
                    dep.Employees.Remove(Del);
                    
                    is_changed = true;
                }
            }
            if (is_changed) Apdate_Employees();
        }
        private void Apdate_Employees()
        {
            this.Employees_List.Items.Clear();
            var add = dep.Employees.OrderBy(x => x.Second_Name).ThenBy(x => x.First_Name).
                Select(x => x.Second_Name + " " + x.First_Name + " " + 
                x.Position + " Salary: " + x.Salary);
            foreach (var ad in add)
            {
                this.Employees_List.Items.Add(ad);
            }
        }
        private void Show_Delete_Btn(object sender, EventArgs e)
        {
            if (this.Employees_List.SelectedItems.Count != 0)
                this.Delete_Employee.Visible = true;
        }

        private void Show_Recruit_Btn(object sender, EventArgs e)
        {
            if(this.Job_Seekers_List.SelectedItems.Count!=0 &&
                this.Vacances_List.SelectedItems.Count != 0)
            {
                this.Recruit_Btn.Visible = true;
            }
        }

        private void Recruit_Btn_Click(object sender, EventArgs e)
        {
            if (this.Job_Seekers_List.SelectedItems.Count == 0 ||
                this.Vacances_List.SelectedItems.Count == 0)
            {
                return;
            }
            //Записываем данные о выбранных соискателях
            List<string> s = new List<string>();
            for (int i = 0; i < this.Job_Seekers_List.Items.Count; i++)
            {
                if (this.Job_Seekers_List.GetItemChecked(i))
                {
                    s.Add(this.Job_Seekers_List.
                        GetItemText(this.Job_Seekers_List.Items[i]));
                }
            }
            //Поиск полных данных выбранных соискателей
            List<Job_Seeker> JBS = new List<Job_Seeker>();
            foreach (var t in s)
            {
                string[] mas = t.Split(' ');
                JBS.Add(dep.Job_Seekers.Where(x => x.Second_Name == mas[0] &&
                x.First_Name == mas[1] && x.Speciality == mas[2]).First());
            }
            //Записываем данные о выбранных ваканчиях
            List<string> va = new List<string>();
            for (int i = 0; i < this.Vacances_List.Items.Count; i++)
            {
                if (this.Vacances_List.GetItemChecked(i))
                {
                    va.Add(this.Vacances_List.
                        GetItemText(this.Vacances_List.Items[i]));
                }
            }
            //Поиск полных данных выбранных вакансий
            List<Vacancy> Vac = new List<Vacancy>();
            foreach (var t in va)
            {
                string[] mas = t.Split(' ');
                Vac.Add(dep.Vacancies.Where(x => x.Speciality == mas[0] &&
                x.Position == mas[1] && x.Salary == Convert.ToDouble(mas[3])).First());
            }
            //Добавление на работу(Создание нового сотрудника)
            int index = 0;
            foreach (var rec in JBS)
            {
                var res = MessageBox.Show($"Recruit {rec.First_Name} {rec.Second_Name} ?",
                    "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        dep.Employees.Add(new Employee(rec, Vac[index]));
                        dep.Job_Seekers.Remove(rec);
                        dep.Vacancies.Remove(Vac[index++]);
                        is_changed = true;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return;
                    }
                }
            }
            if (is_changed)
            {
                Apdate_Employees();                
                Apdate_JBS_Vac();
            }
        }
        private void Apdate_JBS_Vac()
        {
            //очистка данных списков для обновления
            this.Job_Seekers_List.Items.Clear();  
            this.Vacances_List.Items.Clear();
            //Заполнение списка работников
            var add = dep.Job_Seekers.OrderBy(x => x.Second_Name).ThenBy(x => x.First_Name).
                Select(x => x.Second_Name + " " + x.First_Name + " " +
                x.Speciality);
            foreach (var ad in add)
            {
                this.Job_Seekers_List.Items.Add(ad);
            }
            // Заполнение списка меющихся вакансий
            add = dep.Vacancies.OrderBy(x => x.Speciality).
                Select(x => x.Speciality + " " + x.Position + " Salary: " +
                x.Salary);
            foreach (var ad in add)
            {
                this.Vacances_List.Items.Add(ad);
            }
        }

        private void Show_Decision_Btn_Quit(object sender, EventArgs e)
        {
            if (this.Orders_for_quiting_List.SelectedItems.Count != 0)
            {
                this.Confirm_Quiting.Visible = true;
                this.Refuse_Quiting.Visible = true;
            }
        }

        private void Show_Decision_Btn_Hire(object sender, EventArgs e)
        {
            if (this.Orders_for_Hiring_List.SelectedItems.Count != 0)
            {
                this.Confirm_Hiring.Visible = true;
                this.Refuse_Hiring.Visible = true;
            }
        }

        private void Confirm_Hiring_Click(object sender, EventArgs e)
        {
            if (this.Orders_for_Hiring_List.SelectedItems.Count == 0)
            {
                return;
            }
            //Записываем данные о выбранных приказах об принятии на работу
            List<string> s = new List<string>();
            for (int i = 0; i < this.Orders_for_Hiring_List.Items.Count; i++)
            {
                if (this.Orders_for_Hiring_List.GetItemChecked(i))
                {
                    s.Add(this.Orders_for_Hiring_List.
                        GetItemText(this.Orders_for_Hiring_List.Items[i]));
                }
            }
            List<Order> order = new List<Order>();
            foreach (var t in s)
            {
                string[] mas = t.Split(' ');
                order.Add(dep.Orders.Where(x =>x.Employee==null && 
                x.Seeker.Second_Name == mas[0] &&
                x.Seeker.First_Name == mas[1] && x.Vacancy.Position == mas[3]&&
                x.Vacancy.Salary==Convert.ToDouble(mas[5])).First());
            }
            foreach(var hi in order)
            {
                var res = MessageBox.Show($"Hire {hi.Seeker.First_Name} {hi.Seeker.Second_Name} ?",
                   "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    dep.Employees.Add(new Employee(hi));
                    dep.Job_Seekers.Remove(hi.Seeker);
                    dep.Vacancies.Remove(hi.Vacancy);
                    hi.Is_Approved = true; //несмотря на то что в последуйщей строчке приказ удаляеться
                                           //на всякий случай записываем что он был просмотрен и подтвержден
                    hi.Is_Cheked = true;
                    dep.Orders.Remove(hi);
                    is_changed = true;
                    this.Apdate_Hire_Orders();
                    this.Apdate_JBS_Vac();
                    this.Apdate_Employees();
                }
            }
        }

        private void Refuse_Hiring_Click(object sender, EventArgs e)
        {
            if (this.Orders_for_Hiring_List.SelectedItems.Count == 0)
            {
                return;
            }
            //Записываем данные о выбранных приказах об отказе на принятии на работу
            List<string> s = new List<string>();
            for (int i = 0; i < this.Orders_for_Hiring_List.Items.Count; i++)
            {
                if (this.Orders_for_Hiring_List.GetItemChecked(i))
                {
                    s.Add(this.Orders_for_Hiring_List.
                        GetItemText(this.Orders_for_Hiring_List.Items[i]));
                }
            }
            List<Order> order = new List<Order>();
            foreach (var t in s)
            {
                string[] mas = t.Split(' ');
                order.Add(dep.Orders.Where(x =>x.Employee== null && 
                x.Seeker.Second_Name == mas[0] &&
                x.Seeker.First_Name == mas[1] && x.Vacancy.Position == mas[3] &&
                x.Vacancy.Salary == Convert.ToDouble(mas[5])).First());
            }
            foreach (var hi in order)
            {
                var res = MessageBox.Show($"Refuse {hi.Seeker.First_Name} {hi.Seeker.Second_Name} ?",
                   "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    hi.Is_Approved = false; //несмотря на то что в последуйщей строчке приказ удаляеться
                                            //на всякий случай записываем что он был просмотрен и подтвержден
                    hi.Is_Cheked = true;
                    dep.Orders.Remove(hi);
                    is_changed = true;
                    this.Apdate_Hire_Orders();
                }
            }
        }
        private void Apdate_Hire_Orders()
        {
            //очистка данных списков для обновления
            this.Orders_for_Hiring_List.Items.Clear();
            //Заполнение
            var add1 = dep.Orders.Where(x => x.Employee == null && x.Is_Cheked == false).
                OrderBy(x => x.Seeker.Second_Name).
                ThenBy(x => x.Seeker.First_Name).
                Select(x => x.Seeker.Second_Name + " " + x.Seeker.First_Name + " Position: " +
                x.Vacancy.Position + " Salary: " + x.Vacancy.Salary);
            foreach (var adding in add1)
            {
                this.Orders_for_Hiring_List.Items.Add(adding);
            }
        }

        private void Confirm_Quiting_Click(object sender, EventArgs e)
        {
            if (this.Orders_for_quiting_List.SelectedItems.Count == 0)
            {
                return;
            }
            //Записываем данные о выбранных приказах
            List<string> s = new List<string>();
            for (int i = 0; i < this.Orders_for_quiting_List.Items.Count; i++)
            {
                if (this.Orders_for_quiting_List.GetItemChecked(i))
                {
                    s.Add(this.Orders_for_quiting_List.
                        GetItemText(this.Orders_for_quiting_List.Items[i]));
                }
            }
            List<Order> order = new List<Order>();
            foreach (var t in s)
            {
                string[] mas = t.Split(' ');
                order.Add(dep.Orders.Where(x =>
                x.Seeker == null &&
                 x.Employee.Second_Name == mas[0] &&
                 x.Employee.First_Name == mas[1] &&
                 x.Vacancy.Position == mas[3] &&
                 x.Vacancy.Salary == Convert.ToDouble(mas[5])).First());
            }
            foreach (var hi in order)
            {
                var res = MessageBox.Show($"Dismiss {hi.Employee.First_Name} {hi.Employee.Second_Name} ?",
                   "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    dep.Employees.Remove(hi.Employee);
                    dep.Vacancies.Add(hi.Vacancy);
                    hi.Is_Approved = true; //несмотря на то что в последуйщей строчке приказ удаляеться
                                           //на всякий случай записываем что он был просмотрен и подтвержден
                    hi.Is_Cheked = true;
                    dep.Orders.Remove(hi);
                    is_changed = true;
                    this.Apdate_Dismiss_Orders();
                    this.Apdate_JBS_Vac();
                    this.Apdate_Employees();
                }
            }
        }
        private void Apdate_Dismiss_Orders()
        {
            //очистка данных списков для обновления
            this.Orders_for_quiting_List.Items.Clear();

            var add2 = dep.Orders.Where(x => x.Seeker == null && x.Is_Cheked == false).
                OrderBy(x => x.Employee.Second_Name).
                ThenBy(x => x.Employee.First_Name).
                Select(x => x.Employee.Second_Name + " " + x.Employee.First_Name + " Position: " +
                x.Vacancy.Position + " Salary: " + x.Vacancy.Salary);
            foreach (var adding in add2)
            {
                this.Orders_for_quiting_List.Items.Add(adding);
            }
        }

        private void Refuse_Quiting_Click(object sender, EventArgs e)
        {
            if (this.Orders_for_quiting_List.SelectedItems.Count == 0)
            {
                return;
            }
            //Записываем данные о выбранных приказах
            List<string> s = new List<string>();
            for (int i = 0; i < this.Orders_for_quiting_List.Items.Count; i++)
            {
                if (this.Orders_for_quiting_List.GetItemChecked(i))
                {
                    s.Add(this.Orders_for_quiting_List.
                        GetItemText(this.Orders_for_quiting_List.Items[i]));
                }
            }
            List<Order> order = new List<Order>();
            foreach (var t in s)
            {
                string[] mas = t.Split(' ');
                order.Add(dep.Orders.Where(x =>
                x.Seeker == null &&
                x.Employee.Second_Name == mas[0] &&
                x.Employee.First_Name == mas[1] &&
                x.Vacancy.Position == mas[3] &&
                x.Vacancy.Salary == Convert.ToDouble(mas[5])).First());
            }
            foreach (var hi in order)
            {
                var res = MessageBox.Show($"Refuse {hi.Employee.First_Name} {hi.Employee.Second_Name} ?",
                   "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    hi.Is_Approved = false; //несмотря на то что в последуйщей строчке приказ удаляеться
                                           //на всякий случай записываем что он был просмотрен и подтвержден
                    hi.Is_Cheked = true;
                    dep.Orders.Remove(hi);
                    is_changed = true;
                    this.Apdate_Dismiss_Orders();
                }
            }
        }

    }
}
