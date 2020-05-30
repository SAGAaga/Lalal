using System;
using System.Linq;
using Human_Department.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Human_Department
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fill_Test_Data()
        {
            Department dep = new Department();
            dep.Fill_Test_Data(100);
            Assert.AreEqual("JobseekerNameJobseekerSurnameRTG1569HightPediatric_radiologyJobseeker",
                (dep.Job_Seekers.Last().First_Name +
                dep.Job_Seekers.Last().Second_Name +
                dep.Job_Seekers.Last().Pasport_Id +
                dep.Job_Seekers.Last().Aducation +
                dep.Job_Seekers.Last().Speciality +
                dep.Job_Seekers.Last().Password));

            Assert.AreEqual("EmployeeNameEmployeeSurnameANK1254HightLoyerEmployee",
                (dep.Employees.Last().First_Name +
                dep.Employees.Last().Second_Name +
                dep.Employees.Last().Pasport_Id +
                dep.Employees.Last().Aducation +
                dep.Employees.Last().Speciality +
                dep.Employees.Last().Password));

            Assert.AreEqual("DirectorNameDirectorSurnameSDK9054HightLoyerDirector",
                (dep.Director.First_Name +
                dep.Director.Second_Name +
                dep.Director.Pasport_Id +
                dep.Director.Aducation +
                dep.Director.Speciality +
                dep.Director.Password));

            Assert.AreEqual("Dog_Trainer13051,75Adolescent_medicine",
                (dep.Vacancies.Last().Position +
                dep.Vacancies.Last().Salary +
                dep.Vacancies.Last().Speciality));

            Assert.AreEqual("FalseFalsed800Dog_Trainer",
                (""+dep.Orders.Last().Is_Approved+
                dep.Orders.Last().Is_Cheked +
                dep.Orders.Last().Seeker.Pasport_Id +
                dep.Orders.Last().Vacancy.Position));
        }
    }
}
