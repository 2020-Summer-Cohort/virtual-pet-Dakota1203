using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPet : Pet
    {
        public OrganicPet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public void SetHunger(int hunger)
        {
            this.Hunger = hunger;

        }
        public int GetHunger()
        {
            return Hunger;

        }
        public void SetBoredom(int boredom)
        {
            Boredom = boredom;

        }

        public int GetBoredom()
        {
            return Boredom;
        }
        public void SetHealth(int health)
        {
            Health = health;
        }
        public int GetHealth()
        {
            return Health;
        }
        public override void Feed()
        {
            Hunger += 40;
            if (Hunger >= 100)
            {
                Hunger = 100;
            }
        }
        public override void Play()
        {
            Boredom += 20;
            if (Boredom >= 100)
            {
                Boredom = 100;
            }
            Hunger -= 10;
            if (Hunger <= 0)
            {
                Hunger = 0;
            }
            Health -= 10;
            if (Health <= 0)
            {
                Health = 0;
            }
        }
        public override void SeeDoctor()
        {
            Health += 30;
            if (Health >= 100)
            {
                Health = 100;
            }

        }
        public override void Tick()
        {
            Hunger -= 5;
            if (Hunger <= 0)
            {
                Hunger = 0;
            }
            Boredom -= 5;
            if (Boredom <= 0)
            {
                Boredom = 0;
            }
            Health -= 5;
            if (Health <= 0)
            {
                Health = 0;
            }
        }
        public override void CheckPetStatus()
        {
            Console.WriteLine($"{Name}'s Hunger level is {Hunger}");
            Console.WriteLine($"{Name}'s Boredom level is {Boredom}");
            Console.WriteLine($"{Name}'s Health level is {Health}");
        }
}
}
