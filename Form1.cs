using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataModels;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();

            statingApp();

        }

        public void statingApp()
        {
            Student student1 = new Student(1, "John Doe", 20, "Computer Science");
            Student student2 = new Student(2, "Jane Smith", 22, "Mathematics");

            Lecturer lecturer1 = new Lecturer(3, "Dr. Brown", 45, "Physics");
            Lecturer lecturer2 = new Lecturer(4, "Prof. Green", 55, "Chemistry");

            people.Add(student1);
            people.Add(student2);
            people.Add(lecturer1);
            people.Add(lecturer2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SortByID();
            PrintPeople();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortByAge();
            PrintPeople();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortByType();
            PrintPeople();
        }


        private void SortByID()
        {
            people = people.OrderBy(p => p.Id).ToList();
        }

        private void SortByAge()
        {
            people = people.OrderBy(p => p.Age).ToList();
        }

        private void SortByType()
        {
            people = people.OrderBy(p => p.GetType().Name).ToList();
        }


        private void PrintPeople()
        {
            richTextBox1.Text = people[0].ToString();
            richTextBox2.Text = people[1].ToString();
            richTextBox3.Text = people[2].ToString();
            richTextBox4.Text = people[3].ToString();
        }
    }
}