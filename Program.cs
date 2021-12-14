using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PersonE3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Skapade en ToValidName metod i Person. Lite onödigt kan
             *  man tycka, men ville träna på metodprogrammering i C#.
             *  Läs kommentarerna i koden i Person-klassen vid intresse.
             */

            #region Exercises 3.1.x

            Person person1 = new("- Anja - lisa-", " svensson");
            person1.Age = 50;
            person1.Weight = 65.8;
            person1.Height = 162d;
            Console.WriteLine(person1.ToString());

            Person person2 = new(" ville   ", " vallaton ");
            person2.Age = 35;
            person2.Weight = 82.5;
            person2.Height = 182d;
            Console.WriteLine(person2.ToString());

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

            #endregion 

            #region Answers to most question within 3.2.x and 3.3.x

            // Fråga 3.2.13: Var läggs en fågelspecifik egenskap vid behov?
            // Svar: Eftersom den gäller för alla fåglar bör den lämpligen läggas i Bird-klassen.
            //  
            // Fråga 3.2.14: Var läggs attribut för djur?
            // Svar: Om den gäller för alla djuren, bör den lämpligen läggas i Animal-klassen.
            //  
            // Fråga 3.3.9: Värför kan man inte lägga Horse i en lista av Dogs?
            // Svar: Horse är helt enkelt inte en Dog och kan inte konverteras till en Dog.
            //       De gemensamma för dem är Animal-klassen, och därför gick det bra att
            //       lägga dem i en lista av Animal.
            //  
            // Fråga 3.3.10: Vilken listtyp är gemensam för alla djuren?
            // Svar: Alla djurklasser implementerar Animal. Därför kan dem sparas i en lista av Animal.

            #endregion

            #region Exercises from 3.3.3 to 3.3.7

            List<Animal> animals = new();
            animals.Add(new Dog("Kalle", 5d, 3.2, "Terrier"));
            animals.Add(new Bird("Anja", 1.2, 3d, 50));
            animals.Add(new Flamingo("Haggan", 4.2, 2.2, 230, "white-brown"));
            animals.Add(new Wolfman("Wolfy", 125d, 25d, "Brownish", 25));

            foreach (Animal animal in animals)
            {
                animal.DoSound();
                if (animal.GetType() == typeof(Wolfman))
                {
                    IPerson ip = (IPerson)animal; // let ip reference to animal as IPerson
                    ip.Talk(); // ip.IPerson-Members
                }
            }

            #endregion

            #region Excercises from 3.3.8 to 3.3.10

            //List<Dog> dogs = new();

            //dogs.Add(new Dog("Svarten", 82d, 6.2, "Mastiff"));
            //dogs.Add(new Dog("Findus", 18d, 3.5, "Golden retriever"));
            //dogs.Add(new Dog("Muffe", 17d, 14.2, "Labrador"));

            //foreach (Animal dog in dogs)
            //{
            //    Console.WriteLine(dog.Stats() + "\n");
            //}

            #endregion

            #region List of animals for the exercises 3.3.11 to 3.3.18

            //List<Animal> animals = new();
            //animals.Add(new Horse("Vinden", 5d, 3.2, "Svart"));
            //animals.Add(new Hedgehog("Taggan", 2.5, 1.2, 153));
            //animals.Add(new Worm("Torris", 5d, 3.2, true));
            //animals.Add(new Dog("Muffe", 15d, 3.2, "Labrador"));
            //animals.Add(new Wolf("Lillan", 25d, 3.2, "Svart"));
            //animals.Add(new Bird("Tjattran", 1.2, 3d, 50));
            //animals.Add(new Pelican("Pelle", 6.2, 2.2, 230, "black-white"));
            //animals.Add(new Flamingo("Haggan", 8.2, 2.2, 230, "white-brown"));
            //animals.Add(new Swan("Faran", 11.2, 2.2, 230, "white"));
            //animals.Add(new Wolfman("Wolfy", 125d, 25d, "Brownish", 25));

            #endregion

            #region Answer to the question 3.3.13
            // —————————————————————————————————————————————————————————————
            // The answer to the question in 3.3.13 :
            // Because the list is of the Animal type and it is implemented of all the animal types,
            // their classes can be referenced by it. All the classes implement and override the Stats()
            // method in Animal with their own version, it can therefore simply be called in the loop.
            // —————————————————————————————————————————————————————————————
            #endregion

            #region Testloop for 3.3.11

            //foreach (Animal animal in animals)
            //{
            //    Console.WriteLine(animal.Stats() + "\n");

            //    if (animal.GetType() == typeof(Wolfman))
            //    {
            //        IPerson ip = (IPerson)animal; // let ip reference to animal as IPerson
            //        ip.Talk(); // ip.IPerson-Members
            //    }
            //}

            #endregion

            #region Testloop for 3.3.14

            //foreach (Animal animal in animals)
            //{
            //    if (animal.GetType() == typeof(Dog))
            //    {
            //        Console.WriteLine(animal.Stats() + "\n");

            //        // 3.3.15 till 3.3.18
            //        // Alternative one: Define Woozy as Static and call
            //        //                  it via its class like Dog.Woozy();
            //        //
            //        // This alternative is probably best. Because this method
            //        // doesn't access any local data within its class.
            //        Console.WriteLine(Dog.Woozy());

            //        // Alternative two: Do NOT define it as Static and call
            //        //                  it via ref to animal as follows.
            //        //Dog dog = (Dog)animal;
            //        //Console.WriteLine(dog.Woozy());  
            //    }
            //}

            #endregion

            #region Exercise 3.4

            //List<UserError > errors = new();

            //errors.Add(new TextInputError());
            //errors.Add(new NumericInputError());
            //errors.Add(new DivByZeroError());
            //errors.Add(new OutOfRangeError());
            //errors.Add(new NullError());

            //foreach (UserError error in errors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}

            #endregion
        }
    }
}
