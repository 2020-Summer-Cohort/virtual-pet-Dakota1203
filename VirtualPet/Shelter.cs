using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> ShelterList = new List<Pet>()
        {
            //new RoboticPet(),
            //new OrganicPet()
        };

        public void AddOrganicPet(Pet pet)
        {
            ShelterList.Add(pet);
        }
        public void AddRoboticPet(Pet pet)
        {
            ShelterList.Add(pet);
        }

        public void CheckAllPetStatus()
        {
            foreach(Pet pet in ShelterList)
            {
                pet.CheckPetStatus();
                Console.WriteLine(" ");
            }

        }
        public void FeedAllPets()
        {
            Console.WriteLine("You fed all the pets in the shelter!");
            foreach (Pet pet in ShelterList)
            {
                pet.Feed();
                pet.CheckPetStatus();
                Console.WriteLine(" ");
            }
        }
        public void PlayWithAllPets()
        {
            Console.WriteLine("You played with all the pets in the shelter!");
            foreach (Pet pet in ShelterList)
            {
                pet.Play();
                pet.CheckPetStatus();
                Console.WriteLine(" ");
            }
        }
        public void AllPetsSeeDoctor()
        {
            Console.WriteLine("You took all the pets in the shelter to the vet!");
            foreach(Pet pet in ShelterList)
            {
                pet.SeeDoctor();
                pet.CheckPetStatus();
                Console.WriteLine(" ");

            }
        }
        public void PrintAllPetDetails()
        {
            Console.WriteLine("List of Shelter Residents:");
            foreach(Pet pet in ShelterList)
            {
                Console.WriteLine($"Name: {pet.Name}");
                Console.WriteLine($"Species: {pet.Species}");
                pet.CheckPetStatus();
                Console.WriteLine(" ");
            }
        }
        public void PrintAllPets()
        {
            int ListNumber = 1;

            Console.WriteLine("List of Pets:");
            foreach(Pet pet in ShelterList)
            {
                string name = pet.GetName();
                Console.WriteLine($"{ListNumber}. {name}");
                ListNumber++;
            }
        }
        public Pet FindPetByIndex(int index)
        {
            Pet selectedPet = ShelterList[index];
            return selectedPet;
        }
        public void RemovePetFromList(Pet pet)
        {
            ShelterList.Remove(pet);
        }
        public void TickAllPets()
        {
            foreach (Pet pet in ShelterList)
            {
                pet.Tick();
            }
        }
    }
}
