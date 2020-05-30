using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Department.Models
{
    [Serializable]
    public class Vacancy
    {
        public string Position { set; get; }
        public string Speciality { set; get; }
        public double Salary{ set; get; }
        public Vacancy(string pos,string spec,double sal)
        {
            Position = pos;
            Salary = sal;
            Speciality = spec;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Vacancy vac = (Vacancy)obj;
            if (Position==vac.Position &&
                Salary==vac.Salary &&
                Speciality==vac.Speciality)
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
