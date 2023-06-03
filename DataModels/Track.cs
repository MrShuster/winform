using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public class Track
    {
        public string TrackName { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        public Track(string trackName)
        {
            TrackName = trackName;
            Courses = new List<Course>();
            Students = new List<Student>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

}
