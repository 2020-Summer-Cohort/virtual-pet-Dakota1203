using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
    {
    public RoboticPet()
        {
            Rust = 60;
            Battery = 50;
            Performance = 30;
        }
    
        public int Rust { get; set; }
        public int Battery { get; set; }
        public int Performance { get; set; }
        public void SetBattery(int battery)
        {
            this.Battery = battery;

        }
        public int GetBattery()
        {
            return Battery;

        }
        public void SetRust(int rust)
        {
            Rust = rust;

        }

        public int GetRust()
        {
            return Rust;
        }
        public void SetPerformance(int performance)
        {
            Performance = performance;
        }
        public int GetPerformance()
        {
            return Performance;
        }

        public override void Feed()
        {
            Battery += 40;
            if (Battery >= 100)
            {
                Battery = 100;
            }
        }

        public override void Play()
        {
            Rust += 20;
            if (Rust >= 100)
            {
                Rust = 100;
            }
            Battery -= 10;
            if (Battery <= 0)
            {
                Battery = 0;
            }
            Performance -= 10;
            if (Performance <= 0)
            {
                Performance = 0;
            }
        }
        public override void SeeDoctor()
        {
            Performance += 30;
            if (Performance >= 100)
            {
                Performance = 100;
            }

        }

        public override void Tick()
        {
            {
                Battery -= 5;
                if (Battery <= 0)
                {
                    Battery = 0;
                }
                Rust -= 5;
                if (Rust <= 0)
                {
                    Rust = 0;
                }
                Performance -= 5;
                if (Performance <= 0)
                {
                    Performance = 0;
                }
            }
        }
        public override void CheckPetStatus()
        {
            Console.WriteLine($"{Name}'s Battery level is {Battery}");
            Console.WriteLine($"{Name}'s Rust level is {Rust}");
            Console.WriteLine($"{Name}'s Performance level is {Performance}");
        }
}
}
