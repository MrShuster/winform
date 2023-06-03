using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataModels
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public List<string> Messages { get; set; }

        public Person()
        {
            Messages = new List<string>();
        }

        public Person(string id, string name, int age, string phoneNumber, string email, string imagePath)
        {
            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            ImagePath = imagePath;
            Messages = new List<string>();
        }

        public void SendMessage(string message)
        {
            Messages.Add(message);
        }
    }

