using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Department.Models
{
    [Serializable]
    public class Job_Seeker:Human
    {
        public Job_Seeker(string fn, string sn, DateTime Birth, string number, string adu, string spec ,string pw)
        {
            Pasport_Id = number;
            First_Name = fn;
            Second_Name = sn;
            Aducation = adu;
            Speciality = spec;
            Birthday = Birth;
            Password = pw;
        }
        public Job_Seeker(Job_Seeker seeker)
        {
            Pasport_Id = seeker.Pasport_Id; ;
            First_Name = seeker.First_Name;
            Second_Name = seeker.Second_Name;
            Aducation = seeker.Aducation;
            Speciality = seeker.Speciality;
            Birthday = seeker.Birthday;
            Password = seeker.Password;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Job_Seeker h = (Job_Seeker)obj;
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
