using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTests
    {
        public OrganicPet testOrganicPet;

        public OrganicPetTests()
        {
            testOrganicPet = new OrganicPet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testOrganicPet);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Fact]
        public void Pet_Should_Have_Name()
        {
            Assert.NotNull(testOrganicPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testOrganicPet.SetName("fluffy");


            Assert.Equal("fluffy", testOrganicPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testOrganicPet.SetName("Fido");

            string testPetName = testOrganicPet.GetName();

            Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            testOrganicPet.Species = "Pet Species";

            Assert.Equal("Pet Species", testOrganicPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testOrganicPet.SetSpecies("Cat");

            Assert.Equal("Cat", testOrganicPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testOrganicPet.SetSpecies("Dog");

            string testPetSpecies = testOrganicPet.GetSpecies();

            Assert.Equal("Dog", testPetSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            testOrganicPet.Hunger = 100;

            Assert.Equal(100, testOrganicPet.Hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testOrganicPet.GetHunger();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Boredom()
        {
            testOrganicPet.Boredom = 100;

            Assert.Equal(100, testOrganicPet.Boredom);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            int testPetBoredom = testOrganicPet.GetBoredom();

            Assert.Equal(60, testPetBoredom);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            testOrganicPet.Health = 100;

            Assert.Equal(100, testOrganicPet.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int testPetHealth = testOrganicPet.GetHealth();

            Assert.Equal(30, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            testOrganicPet.Feed();

            Assert.Equal(10, testOrganicPet.GetHunger());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            testOrganicPet.SeeDoctor();

            Assert.Equal(60, testOrganicPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testOrganicPet.Play();

            Assert.Equal(60, testOrganicPet.GetHunger());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            testOrganicPet.Play();

            Assert.Equal(40, testOrganicPet.GetBoredom());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testOrganicPet.Play();

            Assert.Equal(40, testOrganicPet.GetHealth());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(55, testOrganicPet.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(65, testOrganicPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(25, testOrganicPet.GetHealth());
        }
    }
}
