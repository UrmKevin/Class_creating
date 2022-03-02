using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creating
{
    class Person
    {
        private string ans; // Поля класса
        string surname;
        string name;
        string gender;
        string status;
        int age;
        int salary;
        Language language;
        public Person() { } // Конструктор
        public Person(string Surname,Language language)
        {
            surname = Surname;
            this.language = language;
        }   // Методы
        public Person(string Surname)
        {
            surname = Surname;
        }
        public Person(string Name, string Surname, int Age)
        {
            name = Name;
            surname = Surname;
            age = Age;
        }
        public Language Language
        {
            get { return language; }
        }
        public string Surname
        {
            set { if (surname == null) surname = value; }
            get { return surname; }
        }   // Свойства
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
            if(name!=null && surname != null)
            {
                Console.WriteLine("Hello! My name is {0} and last name is {1}", name, surname);
            }
            else if (surname==null && name!=null)
            {
                Console.WriteLine("Hello! My name is {0}", name);
            }
            else if (name==null && surname!=null)
            {
                Console.WriteLine("Hello! My last name is {0}", surname);
            }
            else
            {
                Console.WriteLine("Hello!");
            }

            if (gender != null && age > 0)
            {
                Console.WriteLine("I'm a {0} {1} years old, and I'm a {2}", gender, age, status);
            }
            else if (age < 0 && gender != null)
            {
                Console.WriteLine("I'm a {0}", gender);
            }
            else if (gender == null && age > 0)
            {
                Console.WriteLine("I'm {0} years old and I'm a {1}", age, status);
            }
            else
            {
                Console.WriteLine("Secret");
            }
        }
        public double SocialTaxes()
        {
            double stax = 0;
            stax = salary * 0.33;
            stax = salary - stax;
            Console.WriteLine("My total salary is {0}",stax);
            return stax;
        }
    }
}
