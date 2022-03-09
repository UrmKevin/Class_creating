using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_creating
{
    class Student : Person
    {
        string ruhm;
        double hinne;
        bool toetus;

        public Student() { }
        public Student(string Name, string Surname) : base
            (Name, Surname)
        {
        }
        public Student(string Name, string Surname, string Ruhm, double Hinne) : base
            (Name, Surname)
        {
            ruhm = Ruhm;
            hinne = Hinne;
        }
        public string Ruhm
        {
            set { ruhm = value; }
            get { return ruhm; }
        }
        public double Hinne
        {
            set { if (value > 0 && value <= 5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne > 3)
                { toetus = true; }
                else
                { toetus = false; }
                return toetus;
            }
        }
        public void Informatsioon()
        {
            string t = "";
            Console.WriteLine("Tere! Minu nimi on {0} {1}", Name, Surname);
            if (Toetus == true)
            {
                t = ":)";
            }
            else if (Toetus==false && hinne>0)
            {
                t = ":(";
            }
            else
            {
                t = "0_0";
            }
            Console.WriteLine("Minu kesakmine hinne on {0}. {1}", hinne, t);
        }
        public override void Kes_ma_olen()
        {
            Console.WriteLine("Ma olen õpilane!");
        }
    }  
}
