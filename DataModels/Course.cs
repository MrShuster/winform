using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class Course
    {
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }

        public Course(string courseName)
        {
            CourseName = courseName;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

}
