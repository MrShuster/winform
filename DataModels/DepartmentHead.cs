using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class DepartmentHead : Teacher
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeachingAssistant> TeachingAssistants { get; set; }

        public DepartmentHead(string id, string name, int age, string phoneNumber, string email, string imagePath, string employeeId, string specialization, int starRating)
            : base(id, name, age, phoneNumber, email, imagePath, employeeId, specialization, starRating)
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            TeachingAssistants = new List<TeachingAssistant>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddTeachingAssistant(TeachingAssistant teachingAssistant)
        {
            TeachingAssistants.Add(teachingAssistant);
        }
    }

}
