using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class Lecturer : Person
    {
        public string Subject { get; set; }

        public Lecturer(int id, string name, int age, string subject) : base(id, name, age)
        {
            Subject = subject;
        }

        public void Teach()
        {
            // Implement teach method
        }

        public void GradeExam()
        {
            // Implement grade exam method
        }

        public override string ToString()
        {
            return $"{Id} - {Name}, {Age}, {Subject}";
        }
    }
}
