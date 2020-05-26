using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterListTests
    {
        Shelter sut;
    
    
        public ShelterListTests()
        {
        sut = new Shelter();
        }
        [Fact]
        public void AddPet_Should_Add_Pet_To_Shelter()
        {
            Pet newPet = new Pet();

            sut.AddPet(newPet);
            
            Assert.Single(sut.ShelterList);
        }
        [Fact]
        public void FindPetByIndex_Should_Return_Correct_Pet()
        {
            Pet petToChoose = new Pet();
            sut.AddPet(petToChoose);
            int myPetIndex = sut.ShelterList.IndexOf(petToChoose);

            Pet returnedFromList = sut.FindPetByIndex(myPetIndex);

            Assert.True(petToChoose.Equals(returnedFromList));
        }
    }
}
