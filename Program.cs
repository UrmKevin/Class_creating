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
            Person i = new Student("Anna", "Kesk");
            i.Kes_ma_olen();
            i.Greetings();
            Person[] inim = new Person[4];

            inim[0] = new Opetaja();
            inim[0].Kes_ma_olen();
            inim[1] = new Student();
            inim[1].Kes_ma_olen();

            //Student boy = new Student("Dan", "Pidre", "TARpv21", 4.2);
            //boy.Informatsioon();

            //Person female = new Person("Cage");
            //Console.WriteLine("How old are you?");
            //female.Age = int.Parse(Console.ReadLine());
            //female.Greetings();
            //female.SocialTaxes();

            Console.ReadKey();
        }
    }
}
