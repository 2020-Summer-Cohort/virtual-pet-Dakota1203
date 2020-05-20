﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public static Pet CreatePet(string name)
        {
            Pet p = new Pet();
            p.Name = name;
            return p;
        }


        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }
    
    
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public string Species { get; set; }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int Hunger { get; set; }
        
        public void SetHunger(int hunger)
        {
            this.Hunger = hunger;
            
        }
        public int GetHunger()
        {
            return Hunger;
            
        }
        public void Feed()
        {
        Hunger -= 40;
        }
        public int Boredom { get; set; }

        public void SetBoredom(int boredom)
        {
            Boredom = boredom;
            
        }

        public int GetBoredom()
        {
            return Boredom;
        }
        public void Play()
        {
            Boredom -= 20;
            Hunger += 10;
            Health -= 10;
        }

        public int Health { get; set; }

        public void SetHealth(int health)
        {
            Health = health;
        }
        public int GetHealth()
        {
            return Health;
        }

        public void SeeDoctor()
        {
            Health -= 30;
        }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health += 5;
        }
        
            
        
    }

}
