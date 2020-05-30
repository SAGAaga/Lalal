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
    //форма для покак изменения зарплаты по времени
    public partial class Salary_Changes : Form
    {

        Employee employee;
        public Salary_Changes(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            List<string> sal = new List<string>(employee.Salaries.Select(x => "" + x));
            List<string> date = new List<string>(employee.Date_Salary_Changed.Select(x => "" + x.Date));
            List<string> res = new List<string>();
            for(int i=0;i<sal.Count;++i)
            {
                int n = sal.OrderBy(x => x.Length).Last().Length;
                string tab = "";
                for(int j = 0; j < 20; ++j)
                {
                    tab += " ";
                }
                for (int j = 0; j < n-sal[i].Length; ++j)
                {
                    tab += " ";
                }
                res.Add(sal[i] + tab + date[i]);
            }

            this.listBox1.DataSource = res;
        }
    }
}
