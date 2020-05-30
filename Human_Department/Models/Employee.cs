using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Department.Models
{
    [Serializable]
    public class Employee: Human
    {
        public string Position { private set; get; }     //должность
        public double Salary { private set; get; }
        public List<double> Salaries { private set; get; }
        public List<DateTime> Date_Salary_Changed { private set; get; }
        public DateTime Date_Start { private set; get; }
        public Employee(Job_Seeker hum, Vacancy vac)
        {
            Salaries = new List<double>();
            Date_Salary_Changed = new List<DateTime>();
            this.Pasport_Id = hum.Pasport_Id;
            this.First_Name = hum.First_Name;
            this.Second_Name = hum.Second_Name;
            this.Aducation = hum.Aducation;
            this.Speciality = hum.Speciality;
            this.Birthday = hum.Birthday;
            this.Password = hum.Password;
            this.Position = vac.Position;
            this.Salary = vac.Salary;
            Change_Salary(this.Salary);
            this.Date_Start = DateTime.Now;
        }
        public Employee(Order or)
        {
            Salaries = new List<double>();
            Date_Salary_Changed = new List<DateTime>();
            this.Pasport_Id = or.Seeker.Pasport_Id;
            this.First_Name = or.Seeker.First_Name;
            this.Second_Name = or.Seeker.Second_Name;
            this.Aducation = or.Seeker.Aducation;
            this.Speciality = or.Seeker.Speciality;
            this.Birthday = or.Seeker.Birthday;
            this.Password = or.Seeker.Password;
            this.Position = or.Vacancy.Position;
            this.Salary = or.Vacancy.Salary;
            Change_Salary(this.Salary);
            this.Date_Start = DateTime.Now;
        }
        public Employee(Employee emp)
        {
            Salaries = new List<double>();
            Date_Salary_Changed = new List<DateTime>();
            Salaries.AddRange(emp.Salaries);
            Date_Salary_Changed.AddRange(emp.Date_Salary_Changed);

            this.Pasport_Id = emp.Pasport_Id;
            this.First_Name = emp.First_Name;
            this.Second_Name = emp.Second_Name;
            this.Aducation = emp.Aducation;
            this.Speciality = emp.Speciality;
            this.Birthday = emp.Birthday;
            this.Password = emp.Password;
            this.Position = emp.Position;
            this.Salary = emp.Salary;
            this.Salary = emp.Salary;
            this.Date_Start = emp.Date_Start;
        }
        public void Change_Salary(double sal)
        {
            Salaries.Add(sal);
            Date_Salary_Changed.Add(DateTime.Now);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Employee h = (Employee)obj;
            if (Pasport_Id == h.Pasport_Id &&
                First_Name == h.First_Name &&
                Second_Name == h.Second_Name &&
                Birthday == h.Birthday &&
                Password == h.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
