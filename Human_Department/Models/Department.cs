using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Department.Models
{
    [Serializable]
    public class Department
    {
        public List<Employee> Employees{private set; get;}
        public List<Job_Seeker> Job_Seekers { private set; get; }
        public List<Vacancy> Vacancies { private set; get; }
        public List<Order> Orders { private set; get; }
        public Employee Director { private set; get; }
        public DateTime Age_Limit { private set; get; }
        public int Limit { private set; get; }

        public Department()
        {
            Limit = 65;
            DateTime now = DateTime.Now;
            Age_Limit=now.AddYears(-Limit);
            Employees = new List<Employee>();
            Job_Seekers = new List<Job_Seeker>();
            Vacancies = new List<Vacancy>();
            Orders = new List<Order>();
            Load();
            List<Employee> out_of_age= Find_Out_Of_Age();
            foreach(var t in out_of_age)
            {
                Orders.Add(new Order(t));
            }
            Fill_Test_Data(100);
        }
        public void Set_Age_Limit(int years)
        {
            Limit = years;
            DateTime now = DateTime.Now;
            Age_Limit = now.AddYears(-Limit);
        }
        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
        public void Chenge_Director(Employee worker)
        {
            Director = worker;
            Employees.Remove(worker);
        }
        public List<Employee> Find_Out_Of_Age() => 
            new List<Employee>(Employees.Where(x => x.Birthday < Age_Limit));
        public void Fill_Test_Data(int n)
        {
            
 
            List<string> pos = new List<string>();
            using (StreamReader sr = new StreamReader("Position.txt",
                System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    pos.Add(line);
                }
            }
 
            List<string> spec = new List<string>();
            using (StreamReader sr = new StreamReader("Speciality.txt",
                System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    spec.Add(line);
                }
            }
            
            
            //Vacancies
            Vacancies.Clear();
            for(int i = 0; i < n*2; ++i)
            {
                Vacancies.Add(new Vacancy(pos[i % 24], 
                    spec[i % 20], 10000 + (i * 15.65)));
            }
            //Job Seekers
            Job_Seekers.Clear();
            for (int i = 1; i <= n*2; ++i)
            {
                Job_Seekers.Add(new Job_Seeker($"Name{i % 50}", $"Surname{i % 200}",
                    DateTime.Now - TimeSpan.FromDays(7000) - TimeSpan.FromDays(i * i),
                    "" + Convert.ToChar(i%120) + $"{i * 8}", "Higher",
                    spec[i % 20], $"{i * 100 + (i + 3) * 10 + i}"));
            }
            //Employees
            Employees.Clear();
            for (int i = 0; i < n; ++i)
            {
                Employees.Add(new Employee(Job_Seekers[i], Vacancies[i]));
                Job_Seekers.Remove(Job_Seekers[i]);
                Vacancies.Remove(Vacancies[i]);
            }
            //Orders
            Orders.Clear();
            for (int i = 0; i < n/2; ++i)
            {
                Orders.Add(new Order(Employees[i]));
                Orders.Add(new Order(Job_Seekers[i],Vacancies[i]));
            }
            //Director
            //Создадим по 1 виду пользователя с более конкретнымми данными 
            //для авторизации и проверки работоспособности приложения
            Employees.Add(new Employee(new Job_Seeker("EmployeeName",
                "EmployeeSurname", DateTime.Now - TimeSpan.FromDays(7000),
                "ANK1254", "Hight", "Loyer", "Employee"), Vacancies.Last()));
            Vacancies.Remove(Vacancies.Last());
            Employees.Add(new Employee(new Job_Seeker("DirectorName",
                "DirectorSurname", DateTime.Now - TimeSpan.FromDays(8000),
                "SDK9054", "Hight", "Loyer", "Director"), Vacancies.Last()));
            Vacancies.Remove(Vacancies.Last());
            Chenge_Director(Employees.Last());
            Job_Seekers.Add( new Job_Seeker("JobseekerName",
                "JobseekerSurname", DateTime.Now - TimeSpan.FromDays(10000),
                "RTG1569", "Hight", "Pediatric_radiology", "Jobseeker"));

        }
    }
}
