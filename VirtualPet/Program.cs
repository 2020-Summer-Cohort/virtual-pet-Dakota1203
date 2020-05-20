using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("What is your pet's name?");
            myPet.SetName(Console.ReadLine());
            Console.WriteLine("What is your pet's species?");
            myPet.SetSpecies(Console.ReadLine());
            Console.WriteLine($"{myPet.GetName()} The {myPet.GetSpecies()} exists!");
            Console.WriteLine("Press Enter to start playing");
            Console.ReadLine();

            bool whilePlaying = true;
            do
            {
                myPet.Tick();
                Console.WriteLine("What do you want to do with your pet?");
                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Play with your pet");
                Console.WriteLine("3. Take your pet to the doctor");
                Console.WriteLine("4. Quit");
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        {
                            myPet.Feed();
                            Console.WriteLine("You fed your pet!");
                            Console.WriteLine($"your pet's Hunger level is {myPet.GetHunger()}");
                            break; }
                    case "2":
                        {
                            myPet.Play();
                            Console.WriteLine("You played with your pet!");
                            myPet.GetBoredom();
                            break;
                        }
                    case "3":
                        {
                            myPet.SeeDoctor(); Console.WriteLine("You took your pet to the doctor!");myPet.GetHealth();
                            break;
                        }
                    case "4":
                        {
                            whilePlaying = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid number");
                            break;
                        }

                }
            } while (whilePlaying);

            
                
        }

        
    }
}
