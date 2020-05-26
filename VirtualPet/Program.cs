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
            Shelter shelter = new Shelter();

            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("What is your pet's name?");
            myPet.SetName(Console.ReadLine());
            Console.WriteLine("What is your pet's species?");
            myPet.SetSpecies(Console.ReadLine());
            Console.WriteLine($"{myPet.GetName()} The {myPet.GetSpecies()} exists!");
            shelter.AddPet(myPet);
            Console.WriteLine("Press Enter to start playing");
            Console.ReadLine();

            bool whilePlaying = true;
            do
            {
                myPet.Tick();
                Console.WriteLine("What do you want to do with your pet?");
                Console.WriteLine("1. Feed a pet");
                Console.WriteLine("2. Play with a pet");
                Console.WriteLine("3. Take a pet to the vet");
                Console.WriteLine("4. Check pet status");
                Console.WriteLine("5. Adopt pet");
                Console.WriteLine("6. Add pet");
                Console.WriteLine("7. Check all pets' status");
                Console.WriteLine("8. Review Shelter list");
                Console.WriteLine("9. Feed all pets");
                Console.WriteLine("10. Play with all pets");
                Console.WriteLine("11. Take all pets to the vet");
                Console.WriteLine("12. Quit");
                string menuChoice = Console.ReadLine();
                Console.Clear();
                switch (menuChoice)
                {
                    case "1":
                        {
                            shelter.PrintAllPets();
                            Console.WriteLine("Which pet would you like to feed?");
                            int petNumber = Convert.ToInt32(Console.ReadLine());
                            Pet petToChoose = shelter.FindPetByIndex(petNumber - 1);
                            petToChoose.Feed();
                            Console.WriteLine($"You fed your pet! {myPet.Name}'s hunger is {myPet.Hunger}");
                            break; }
                    case "2":
                        {
                            shelter.PrintAllPets();
                            Console.WriteLine("Which pet would you like to play with?");
                            int petNumber = Convert.ToInt32(Console.ReadLine());
                            Pet petToChoose = shelter.FindPetByIndex(petNumber - 1);
                            myPet.Play();
                            Console.WriteLine($"You played with your pet! {myPet.Name}'s boredom is {myPet.Boredom}");
                            break;
                        }
                    case "3":
                        {
                            shelter.PrintAllPets();
                            Console.WriteLine("Which pet would you like to take to the vet?");
                            int petNumber = Convert.ToInt32(Console.ReadLine());
                            Pet petToChoose = shelter.FindPetByIndex(petNumber - 1);
                            myPet.SeeDoctor();
                            Console.WriteLine($"You took your pet to the vet! {myPet.Name}'s Health is {myPet.Health}" +
                                $"");
                            myPet.GetHealth();
                            break;
                        }
                    case "4":
                        {
                            myPet.CheckPetStatus();
                            break;
                        }
                    case "5":
                        {
                            shelter.PrintAllPets();
                            Console.WriteLine("Which pet will be adopted? This pet will be permanently removed from the shelter");
                            int petNumber = Convert.ToInt32(Console.ReadLine());
                            Pet petToChoose = shelter.FindPetByIndex(petNumber - 1);
                            shelter.RemovePetFromList(petToChoose);
                            Console.WriteLine($"{petToChoose.GetName()} Found a new home :)");
                            break;
                        }
                    case "6":
                        {
                            myPet = new Pet();
                            Console.WriteLine("What is your pet's name?");
                            myPet.SetName(Console.ReadLine());
                            Console.WriteLine("What is your pet's species?");
                            myPet.SetSpecies(Console.ReadLine());
                            shelter.AddPet(myPet);
                            Console.WriteLine($"{myPet.GetName()} The {myPet.GetSpecies()} exists!");
                                break;
                        }
                    case "7":
                        {
                            shelter.CheckAllPetStatus();
                            break;
                        }
                    case "8":
                        {
                            shelter.PrintAllPetDetails();
                            break;
                        }
                    case "9":
                        {
                            shelter.FeedAllPets();
                            break;
                        }
                    case "10":
                        {
                            shelter.PlayWithAllPets();
                            break;
                        }
                    case "11":
                        {
                            shelter.AllPetsSeeDoctor();
                            break;
                        }
                    case "12":
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
