using System;
namespace PetSimulation
{
     class User
    {
        public double numberOfCoins;

                public Inventory inventory = new Inventory();
     public void DisplayCurrentNumberOfCoins()
        {
               Console.WriteLine($"The current number of coins you have is: {numberOfCoins} ") ; //Displays number of coins
        }
               public User(int numberOfCoins) 
               {
                   this.numberOfCoins=numberOfCoins;
               }

               public void Update()
               {
                   numberOfCoins+=0.5; //Coin increasing
               }

                  
    }
}