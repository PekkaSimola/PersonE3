using System;
using System.Diagnostics;

namespace PersonE3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person person1 = new(" Anja - lisa", " svensson");
            //person1.Age = 50;
            //person1.Weight = 65.8;
            //person1.Height = 162d;
            //Console.WriteLine(person1.ToString());

            //Person person2 = new(" ville   ", " vallaton ");
            //person2.Age = 35;
            //person2.Weight = 82.5;
            //person2.Height = 182d;
            //Console.WriteLine(person2.ToString());

            Person p1 = PersonHandler.CreatePerson(" Anja - lisa", " svensson", 50, 162d, 65.8);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(PersonHandler.ToEnglishString(p1));

            PersonHandler.SetAge(p1, 55);
            PersonHandler.SetHeight_cm(p1, 180d);
            PersonHandler.SetWeight_kg(p1, 68.8);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(PersonHandler.ToEnglishString(p1));

            PersonHandler.SetHeight_inches(p1, 70.87);
            PersonHandler.SetWeight_pounds(p1, 151.54);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(PersonHandler.ToEnglishString(p1));


        }
    }
}
