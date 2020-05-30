using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Department.Models
{
    [Serializable]
    public abstract class Human
    {
        public string Pasport_Id { protected set; get;}
        public string First_Name { protected set; get; }
        public string Second_Name { protected set; get; }
        public DateTime Birthday { protected set; get; }
        public string Aducation { protected set; get; }
        public string Password { protected set; get; }
        public string Speciality { protected set; get; }     //специальность

        public override bool Equals(object obj)
        {
            if(!base.Equals(obj))
            {
                return false;
            }
            Human h = (Human)obj;
            if(Pasport_Id==h.Pasport_Id &&
                First_Name==h.First_Name &&
                Second_Name==h.Second_Name &&
                Birthday==h.Birthday &&
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
