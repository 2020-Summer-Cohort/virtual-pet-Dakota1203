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
            new RoboticPet(),
            new OrganicPet()
        };

        public void AddOrganicPet(Pet pet)
        {
            ShelterList.AddOrganicPet(pet);
        }
        public void AddRoboticPet(Pet pet)
        {
            ShelterList.AddRoboticPet(pet);
        }

        public void CheckAllPetStatus()
        {
            foreach(Pet pet in ShelterList)
            {
                pet.CheckPetStatus();
            }

        }
        public void FeedAllPets()
        {
            foreach (Pet pet in ShelterList)
            {
                pet.Feed();
            }
        }
        public void PlayWithAllPets()
        {
            foreach (Pet pet in ShelterList)
            {
                pet.Play();
            }
        }
        public void AllPetsSeeDoctor()
        {
            foreach(Pet pet in ShelterList)
            {
                pet.SeeDoctor();
            }
        }
        public void PrintAllPetDetails()
        {
            Console.WriteLine("List of Shelter Residents:");
            foreach(Pet pet in ShelterList)
            {
                Console.WriteLine($"Name: {pet.Name}");
                Console.WriteLine($"Species: {pet.Species}");
                Console.WriteLine($"{pet.Name}'s Hunger level is {pet.Hunger}");
                Console.WriteLine($"{pet.Name}'s Boredom level is {pet.Boredom}");
                Console.WriteLine($"{pet.Name}'s Health level is {pet.Health}");
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
    }
}
