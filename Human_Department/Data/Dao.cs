using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Human_Department.Models;

namespace Human_Department
{
    public class Dao
    {
        Department dep;
        const string filePath = "store.bin";

        public Dao(Department dep)
        {
            this.dep = dep;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, dep);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                try
                {
                    Department st = (Department)serializer.Deserialize(stream);

                    Copy(st.Employees, dep.Employees);
                    Copy(st.Job_Seekers, dep.Job_Seekers);
                    Copy(st.Vacancies, dep.Vacancies);
                    Copy(st.Orders, dep.Orders);
                    dep.Chenge_Director(st.Director);
                    dep.Set_Age_Limit(st.Limit);
                }
                catch (System.Runtime.Serialization.SerializationException)
                {

                }
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                try
                {
                    to.Clear();
                    to.AddRange(from);
                }
                catch(ArgumentNullException)
                {

                }
            }
        }
    }
}
