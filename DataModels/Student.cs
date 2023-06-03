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
        public string Major { get; set; }

        public Student(int id, string name, int age, string major) : base(id, name, age)
        {
            Major = major;
        }

        public void Study()
        {
            // Implement study method
        }

        public void TakeExam()
        {
            // Implement take exam method
        }

        public override string ToString()
        {
            return $"{Id} - {Name}, {Age}, {Major}";
        }
    }
}
