using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonE3
{
    struct PersonHandler
    {
        const double INCH = 2.54, POUND = 0.454;

        public static Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            try
            {
                Person pers = new(fname, lname, age, height, weight);
                return pers;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void SetAge(Person person, int age) { person.Age = age; }
        public static int GetAge(Person person) { return person.Age; }

        public static void SetHeight_cm(Person person, double height) { person.Height = height; }
        public static double GetHeight_cm(Person person) { return person.Height; }
        public static void SetHeight_inches(Person person, double height) { person.Height = height * INCH; }
        public static double GetHeight_inches(Person person) { return person.Height / INCH; }

        public static void SetWeight_kg(Person person, double weight) { person.Weight = weight; }
        public static double GetWeight_kg(Person person) { return person.Weight; }
        public static void SetWeight_pounds(Person person, double weight) { person.Weight = weight * POUND; }
        public static double GetWeight_pounds(Person person) { return person.Weight / POUND; }

        public static void SetFName(Person person, string fName) { person.FName = fName; }
        public static string GetFName(Person person) { return person.FName; }

        public static void SetLName(Person person, string lName) { person.LName = lName; }
        public static string GetLName(Person person) { return person.LName; }

        public static string ToString(Person p) => $"\nfName: {p.FName}\nlName: {p.LName}\nage: {p.Age} years\nheight: {Math.Round(p.Height, 1)} cm\nweigth: {Math.Round(p.Weight, 1)} kg";
        public static string ToEnglishString(Person p) => $"\nfName: {p.FName}\nlName: {p.LName}\nage: {p.Age} years\nheight: {Math.Round(p.Height / INCH, 1) }\"\nweigth: {Math.Round(p.Weight / POUND, 1)} pounds";
    }
}
