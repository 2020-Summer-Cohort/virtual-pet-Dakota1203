using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. new pet");
            Console.WriteLine("2. choose pet");
            Console.WriteLine("3. quit");
            Console.ReadLine();
            string input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            if (i == 1) 
            {
                Pet myPet = CreatePet();
            }
            else;
                
        }

        
    }
}
