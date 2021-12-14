using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonE3
{
    public class Person
    {
        // required properties:    
        private string fName; // 2–10 characters
        private string lName; // 2–15 characters

        // optional properties; default = 0
        private int age;       // given value > 0
        private double height; // unit: centimeters
        private double weight; // unit: kilograms

        public Person(string fName, string lName) : this(fName, lName, 0, 0d, 0d) { }

        public Person(string fName, string lName, int age, double height, double weight) // give all properties
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public string FName
        {
            get { return fName; }
            set
            {
                string validatedName = ToValidName(value);
                int len = validatedName.Length;
                if (len < 3 || len > 10)
                    throw new ArgumentException("FName: 2 to 10 name-characters expected!");

                else fName = validatedName;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                string validatedName = ToValidName(value);
                int len = validatedName.Length;
                if (len < 3 || len > 15)
                    throw new ArgumentException("LName: 2 to 15 name-characters expected!");

                else lName = validatedName;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age in years: Positive integer expected!");

                else age = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Height in centimeters: positive number expected!");

                else height = Math.Round(value); // limit to 3 decimals
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight in kilogram: Positive number expected!");

                else weight = Math.Round(value); // limit to 3 decimals
            }
        }

        /*
        * Returns all the private fields from its instance as a string.
        * Changed from using StringBuilder: this syntax looks cleaner
        * (I imagine it uses StringBuilder internt anyway) 
        */
        public override string ToString() => $"\nfName: {fName}\nlName: {lName}\nage: {age} years\nheight: {Math.Round(height, 1)} cm\nweigth: {Math.Round(weight, 1)} kg";

        /// <summary>
        /// ToValidName returns a cleaned up nameIn-argument as follows:
        /// • It will keep the english letters, ÅÄÖ, single spaces and hyphens in both lower and upper cases.
        ///   Their ascii values are: A..Z = 65..90; a..z = 97..122; Å=197, å=229, Ä=196, ä=228, Ö=214 and ö=246
        ///   
        /// • A single space (ascii=32) or hyphen (ascii=45) is allowed between the words.
        /// 
        /// • Just the very first letter of the word(s) are captalized to allow f.ex. imput of McClean.
        /// 
        /// • If nameIn is null or doesn't contain any valid characters, an empty string ("") is returned.
        /// </summary>
        /// <param name="nameIn"></param>
        /// <returns></returns>
        public static string ToValidName(string nameIn)

        {
            if (nameIn == null) return "";

            const int SPACE_ASCII = 32, HYPHEN_ASCII = 45;

            int ascii = 0, pos = 0;

            // only one space or hyphen between the names
            int spaces = 0, hyphens = 0;
            bool prevHyphen = false, prevSpace = false;

            // make sure there is something to check
            string unvalidatedName = nameIn.Trim();
            if (unvalidatedName.Length == 0) return "";

            // init for preceding hyphen
            if (unvalidatedName[..1].Equals("-"))
            {
                hyphens++;
                prevHyphen = true;
            }

            // characters to keep is added into charList
            StringBuilder charList = new();

            foreach (char ch in unvalidatedName)
            {
                pos++;
                ascii = (int)ch;

                if (ascii == SPACE_ASCII)
                {
                    if (spaces == 0)
                    {
                        if (prevHyphen == false)
                        {
                            charList.Append(ch);

                            // prepare for next round
                            prevSpace = true;
                            spaces++;
                        }
                    }
                }
                else if (ascii == HYPHEN_ASCII)
                {
                    if (hyphens == 0)
                    {
                        if (prevSpace == true)
                        {
                            // remove the last space to prevent input of " -"
                            charList.Length--;
                            prevSpace = false;
                        }
                        charList.Append(ch);

                        // prepare for next round
                        hyphens++;
                        prevHyphen = true;
                        spaces = 0;
                    }
                }
                // remaining valid letters: a..z, å, ä and ö in lower and upper cases
                else if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122) || ascii == 196 || ascii == 197 || ascii == 214 || ascii == 228 || ascii == 229 || ascii == 246)
                {
                    if ((spaces + hyphens) > 0 || pos == 1)
                        charList.Append(ch.ToString().ToUpper()); // capitalize the first letter of every word

                    else charList.Append(ch);

                    // prepare for next round
                    spaces = 0;
                    hyphens = 0;
                    prevHyphen = false;
                    prevSpace = false;
                }
            }

            /*
             * return a validated name-string; which is either a blank
             * string or a validated string without a concluding hyphen
             */
            string validName = charList.ToString();

            pos = validName.Length - 1; // position of the last character

            if (pos < 0) 
                return ""; // nothing valid to return

            else if (validName.Substring(pos, 1).Equals("-"))
                return validName[..pos]; // exclude the concluding hyphen

            else return validName;
        }
    }
}