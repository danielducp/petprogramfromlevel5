using System;
using System.Collections.Generic;
using System.Linq;

namespace PetSimulation
{
     class PetShop
    {
                List<PetItem> petshop = new List<PetItem>();
        public PetShop()
        {
            PetToy rope = new PetToy("Rope", 15, 5, 10, 3); //Creates an Instance of pettoy
            PetToy tennisball = new PetToy("Tennis Ball", 40, 19, 20, 10);//Creates an Instance of pettoy
            Food cheapFood = new Food("Morrisons Value Pet Food", 30, 1, 25, 10);//Creates an Instance of food
            Food expensiveFood = new Food("Royal Canin Pet Food", 90, 1, 75, 20);//Creates an Instance of food
            Medicine cheapMedicine = new Medicine("Cheap Medicine", 35, 1, 25, 40);//Creates an Instance of medicine
            Medicine expensiveMedicine = new Medicine("Expensive Medicine", 99, 1, 70, 15);//Creates an Instance of medicine
            Sleep thirtyminuteSleep = new Sleep("30 minute sleep", 1, 1, 10, 5, 40);//Creates an Instance of sleep
            Sleep sixtyminuteSleep = new Sleep("60 minute sleep", 2, 1, 20, 10, 90);//Creates an Instance of sleep
            petshop.Add(rope); //Adds to shop list
            petshop.Add(tennisball);//Adds to shop list
            petshop.Add(cheapFood);//Adds to shop list
            petshop.Add(expensiveFood);//Adds to shop list
            petshop.Add(cheapMedicine);//Adds to shop list
            petshop.Add(expensiveMedicine);//Adds to shop list
            petshop.Add(thirtyminuteSleep);//Adds to shop list
        }

        public void UpdatePetItems()
        {
            petshop.Clear();

            PetToy rope = new PetToy("Rope", 15, 5, 10, 3); //Creates an Instance of pettoy
            PetToy tennisball = new PetToy("Tennis Ball", 40, 19, 20, 10);//Creates an Instance of pettoy
            Food cheapFood = new Food("Morrisons Value Pet Food", 30, 1, 25, 10);//Creates an Instance of food
            Food expensiveFood = new Food("Royal Canin Pet Food", 90, 1, 75, 20);//Creates an Instance of food
            Medicine cheapMedicine = new Medicine("Cheap Medicine", 35, 1, 25, 40);//Creates an Instance of medicine
            Medicine expensiveMedicine = new Medicine("Expensive Medicine", 99, 1, 70, 15);//Creates an Instance of medicine
            Sleep thirtyminuteSleep = new Sleep("30 minute sleep", 1, 1, 10, 5, 40);//Creates an Instance of sleep
            Sleep sixtyminuteSleep = new Sleep("60 minute sleep", 2, 1, 20, 10, 90);//Creates an Instance of sleep
            petshop.Add(rope); //Adds to shop list
            petshop.Add(tennisball);//Adds to shop list
            petshop.Add(cheapFood);//Adds to shop list
            petshop.Add(expensiveFood);//Adds to shop list
            petshop.Add(cheapMedicine);//Adds to shop list
            petshop.Add(expensiveMedicine);//Adds to shop list
            petshop.Add(thirtyminuteSleep);//Adds to shop list
        }

        public void PrintShoppingList(User user)
        {
           Console.Clear();
                      Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour  
            UpdatePetItems();
            Console.WriteLine();
                                 Console.SetCursorPosition(50, 5); //Sets the text output

         Console.WriteLine("  #####                       ");
                              Console.SetCursorPosition(50, 6); 

         Console.WriteLine(" #     # #    #  ####  #####  ");
                              Console.SetCursorPosition(50, 7); 

         Console.WriteLine(" #       #    # #    # #    # ");
                              Console.SetCursorPosition(50, 8); 

         Console.WriteLine("  #####  ###### #    # #    # ");
                              Console.SetCursorPosition(50, 9); 

         Console.WriteLine("       # #    # #    # #####  ");
                              Console.SetCursorPosition(50, 10); 


         Console.WriteLine(" #     # #    # #    # #      ");
                              Console.SetCursorPosition(50, 11); 

         Console.WriteLine("  #####  #    #  ####  #      \n\n");
  Console.SetCursorPosition(50, 12); 
                                             user.DisplayCurrentNumberOfCoins(); //Displays the number of coins in the shop


            int u = 0;
            foreach (PetItem PetItem in petshop) //Lists each item in the shop
            {
                     Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour
   
                Console.WriteLine(u + ") " + PetItem.NameOfItem);
                Console.WriteLine($"Each item costs: {PetItem.CostOfPetItem} coins");
                Console.WriteLine($"Total number of uses before it runs out: {PetItem.NumberOfUses}");
        
 
                Console.WriteLine();
                         
                u ++;

            }
            Shopping(user);
        }

        public void Shopping(User user) //Asks the user to enter a number to purchase a product, takes in the input
        {
            Console.WriteLine("Enter your preferred item to buy: ");
            int userShoppingChoice = Convert.ToInt32(Console.ReadLine());
            PetItem selectedPetItem = petshop.ElementAt(userShoppingChoice);
            BuyAPetItem(selectedPetItem, user);
        }

        public void BuyAPetItem(PetItem selectedPetItem, User user)
        {
            if (user.numberOfCoins - selectedPetItem.CostOfPetItem < 0)
            {
                Console.WriteLine("Not enough coins, try again later on!"); //Outputted if not enough couns are valid
                Shopping(user);
            }
            else
            {
                user.numberOfCoins = user.numberOfCoins - selectedPetItem.CostOfPetItem; //Coin total goes down depending on cost of item
                user.inventory.AddToInventory(selectedPetItem); //Pet Item added to inverntory
            }
        }

    }
}
