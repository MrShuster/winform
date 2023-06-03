using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class Teacher : Person
    {
        public string EmployeeId { get; set; }
        public List<string> Courses { get; set; }
        public string Specialization { get; set; }
        public int StarRating { get; set; }

        public Teacher(string id, string name, int age, string phoneNumber, string email, string imagePath, string employeeId, string specialization, int starRating) : base(id, name, age, phoneNumber, email, imagePath)
        {
            EmployeeId = employeeId;
            Specialization = specialization;
            StarRating = starRating;
            Courses = new List<string>();
        }

        public void AddCourse(string course)
        {
            Courses.Add(course);
        }
    }

}
