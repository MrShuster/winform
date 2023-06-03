using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.DataModels
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public int CurrentCreditPoints { get; set; }
        public int TotalCreditPoints { get; set; }

        public Student(string id, string name, int age, string phoneNumber, string email, string imagePath, string studentId, string course, string specialization, int currentCreditPoints, int totalCreditPoints) : base(id, name, age, phoneNumber, email, imagePath)
        {
            StudentId = studentId;
            Course = course;
            Specialization = specialization;
            CurrentCreditPoints = currentCreditPoints;
            TotalCreditPoints = totalCreditPoints;
        }
    }


}
