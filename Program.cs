using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creating
{
    class Program
    {
        static void Main(string[] args)
        {
            Person female = new Person("Cage");
            Console.WriteLine("How old are you?");
            female.Age = int.Parse(Console.ReadLine());
            female.Greetings();
            female.SocialTaxes();
            //Person male = new Person();
            //male.Surname = "Sugoma";
            //male.Age = 3;
            //Console.WriteLine(male.Surname, " is ", male.Age, " years old male");
            //male.Greetings();
            //Person[] people = new Person[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    people[i] = new Person();
            //    Console.WriteLine("What is your last name?");
            //    people[i].Surname = Console.ReadLine();
            //    Console.WriteLine("How old are you?");
            //    people[i].Sge = int.Parse(Console.ReadLine());
            //}
            //foreach (Person person in people)
            //{
            //    person.Greetings();
            //}

            Console.ReadKey();
        }
    }
}
