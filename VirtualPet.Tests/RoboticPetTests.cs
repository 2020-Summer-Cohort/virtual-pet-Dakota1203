using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticPetTests
    {
        public RoboticPet testRoboticPet;

        public RoboticPetTests()
        {
            testRoboticPet = new RoboticPet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testRoboticPet);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact]
        public void Pet_Should_Have_Name()
        {
            Assert.NotNull(testRoboticPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testRoboticPet.SetName("fluffy");


            Assert.Equal("fluffy", testRoboticPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testRoboticPet.SetName("Fido");

            string testPetName = testRoboticPet.GetName();

            Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            testRoboticPet.Species = "Pet Species";

            Assert.Equal("Pet Species", testRoboticPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testRoboticPet.SetSpecies("Cat");

            Assert.Equal("Cat", testRoboticPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testRoboticPet.SetSpecies("Dog");

            string testPetSpecies = testRoboticPet.GetSpecies();

            Assert.Equal("Dog", testPetSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Battery()
        {
            testRoboticPet.Battery = 100;

            Assert.Equal(100, testRoboticPet.Battery);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Battery_Level_Of_50()
        {
            int testPetHunger = testRoboticPet.GetBattery();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Rust()
        {
            testRoboticPet.Rust = 100;

            Assert.Equal(100, testRoboticPet.Rust);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Rust_Level_Of_60()
        {
            int testPetBoredom = testRoboticPet.GetRust();

            Assert.Equal(60, testRoboticPet.Rust);
        }

        [Fact]
        public void Pet_Should_Have_Performance()
        {
            testRoboticPet.Performance = 100;

            Assert.Equal(100, testRoboticPet.Performance);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Performance_Level_Of_30()
        {
            int testPetHealth = testRoboticPet.GetPerformance();

            Assert.Equal(30, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Battery_By_40()
        {
            testRoboticPet.Feed();

            Assert.Equal(10, testRoboticPet.GetBattery());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Battery_By_30()
        {
            testRoboticPet.SeeDoctor();

            Assert.Equal(60, testRoboticPet.GetBattery());
        }

        [Fact]
        public void Play_Should_Increase_Battery_By_10()
        {
            testRoboticPet.Play();

            Assert.Equal(60, testRoboticPet.GetBattery());
        }

        [Fact]
        public void Play_Should_Decrease_Rust_By_20()
        {
            testRoboticPet.Play();

            Assert.Equal(40, testRoboticPet.GetRust());
        }

        [Fact]
        public void Play_Should_Increase_Performance_By_10()
        {
            testRoboticPet.Play();

            Assert.Equal(40, testRoboticPet.GetPerformance());
        }

        [Fact]
        public void Tick_Should_Increase_Battery_By_5()
        {
            testRoboticPet.Tick();

            Assert.Equal(55, testRoboticPet.GetBattery());
        }

        [Fact]
        public void Tick_Should_Increase_Rust_By_5()
        {
            testRoboticPet.Tick();

            Assert.Equal(65, testRoboticPet.GetRust());
        }

        [Fact]
        public void Tick_Should_Decrease_Performance_By_5()
        {
            testRoboticPet.Tick();

            Assert.Equal(25, testRoboticPet.GetPerformance());
        }
    }
}