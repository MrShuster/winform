using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class TeachingAssistant : Student
    {
        public List<string> AssistableCourses { get; set; }

        public TeachingAssistant(string id, string name, int age, string phoneNumber, string email, string imagePath, string studentId, string course, string specialization, int currentCreditPoints, int totalCreditPoints)
            : base(id, name, age, phoneNumber, email, imagePath, studentId, course, specialization, currentCreditPoints, totalCreditPoints)
        {
            AssistableCourses = new List<string>();
        }

        public void AddAssistableCourse(string course)
        {
            AssistableCourses.Add(course);
        }
    }

}
