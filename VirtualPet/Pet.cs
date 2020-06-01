using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public abstract class Pet
    {
        //public static Pet CreatePet(string name)
        //{
        //    Pet p = new Pet();
        //    p.Name = name;
        //    return p;
        //}
    
    
        public string Name { get; set; }
        public string Species { get; set; }



        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }


        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }
        public abstract void Feed();
        public abstract void Play();
        public abstract void SeeDoctor();
        public abstract void Tick();
        public abstract void CheckPetStatus();
    }

}
