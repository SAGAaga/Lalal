using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Department.Models
{
    [Serializable]
    public class Order
    {
        public DateTime Date { private set; get; }
        public Job_Seeker Seeker { private set; get; }
        public Employee Employee { private set; get; }
        public Vacancy Vacancy { private set; get; }
        public bool Is_Approved { set; get; }  //решение директора о приказе 
        public bool Is_Cheked { set; get; }  //был ли приказ просмотрен 
                                                     //и было ли принято решение
        public Order(Job_Seeker seeker,Vacancy vac)
        {
            this.Seeker =new Job_Seeker (seeker);
            Vacancy = vac;
            Is_Approved = false;
            Is_Cheked = false;
            Employee = null;
            Date = DateTime.Now;
        }
        public Order(Employee employee)
        {
            this.Employee = new Employee(employee);
            Is_Approved = false;
            Is_Cheked = false;
            Vacancy = new Vacancy(employee.Position,employee.Speciality, employee.Salary);
            Seeker = null;
            Date = DateTime.Now;
        }
    }
}
