using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creating
{
    class Person
    {
        private string ans;
        string surname;
        string name;
        string gender;
        string status;
        int age;
        int salary;
        public Person() { }
        public Person(string Surname)
        {
            surname = Surname;
        }
        public Person(string Name, string Surname)
        {
            name = Name;
            surname = Surname;
        }
        public string Surname
        {
            set { if (surname == null) surname = value; }
            get { return surname; }
        }
        public string Name
        {
            set { if (name == null) name = value; }
            get { return name; }
        }
        public string Gender
        {
            set { if (gender == null) gender = value; }
            get { return gender; }
        }
        public int Age
        {
            set
            {
                age = value;
                salary = value;
                if (age < 7)
                {
                    status = "kid";
                }
                else if (age<17)
                {
                    status = "teenager";
                }
                else if (age < 24)
                {
                    status = "university student";
                }
                else
                {
                    Console.WriteLine("Do you have work?");
                    ans = Console.ReadLine();
                    ans = ans.ToLower();
                    if (ans == "yes")
                    {
                        Console.WriteLine("What is your brutto salary?");
                        salary = int.Parse(Console.ReadLine());
                    }
                    status = "adult";
                }
            }
            get { return age; }
        }
        public string Status
        {
            get { return status; }
        }
        public int Salary
        {
            get { return salary; }
        }
        public void Greetings()
        {
            Console.WriteLine("Hello! My name is {0} and last name is {1}", name, surname);
            Console.WriteLine("I'm a {0} years old {1}, and I'm a {2}", gender, age, status);
        }
        public void sth()
        {
            Console.WriteLine();
        }
    }
}
