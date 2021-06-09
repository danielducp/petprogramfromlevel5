using System;
using System.Collections.Generic;
using System.Linq;
namespace PetSimulation
{
     class Inventory
    {
        
        List<PetItem> inventory = new List<PetItem>();

        public void AddToInventory(PetItem PetItem)
        {
            inventory.Add(PetItem);
        }

        public void DisplayFood(Pet pet)
        {
            List<Food> inventoryFood = new List<Food>();
                Console.Clear();

            Console.WriteLine();
                             Console.SetCursorPosition(50, 5); 

        Console.WriteLine(" #######                      ");
                         Console.SetCursorPosition(50, 6); 

        Console.WriteLine(" #        ####   ####  #####  ");
                         Console.SetCursorPosition(50, 7); 

        Console.WriteLine(" #       #    # #    # #    # ");
                         Console.SetCursorPosition(50, 8); 

        Console.WriteLine(" #####   #    # #    # #    # ");
                         Console.SetCursorPosition(50, 9); 

        Console.WriteLine(" #       #    # #    # #    # ");
                         Console.SetCursorPosition(50, 10); 

        Console.WriteLine(" #       #    # #    # #    # ");
                         Console.SetCursorPosition(50, 11); 

        Console.WriteLine(" #        ####   ####  #####  \n\n");

            foreach (PetItem petitem in inventory)
            {
                if (petitem.GetType() == typeof(Food))
                {
                    Food invFoodPetItem = (Food)petitem;
                    inventoryFood.Add(invFoodPetItem);
                }
            }

            if (inventoryFood.Count == 0)
            {
                                 Console.SetCursorPosition(50, 12); 

                Console.WriteLine("Unfortunately there is no food available");
            }
            else
            {
                foreach (Food availablefood in inventoryFood)
                {
               
                    Console.WriteLine();
                    Console.WriteLine($"Item Name: {availablefood.NameOfItem}");
                    Console.WriteLine($"Number of uses left:  {availablefood.NumberOfUses}");
                    Console.WriteLine($"Press the number on the keyboard to select one, 0 is always the first number.");

           
                }

                int userStringSelection;

                Console.WriteLine("Please choose your preferred food: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Food userSelectedPetItem = inventoryFood.ElementAt(userStringSelection);

                if (userSelectedPetItem.NumberOfUses - 1 < 0)
                {
                    Console.WriteLine($"Unfortunately {userSelectedPetItem.NameOfItem} has run out. You need to purchase some more from the store");
                    inventoryFood.Remove(userSelectedPetItem);
                    inventory.Remove(userSelectedPetItem);
                }
                else
                {
                    pet.EatFood(userSelectedPetItem);
                }
            }
        }

        public void DisplayToy(Pet pet)
        {
            List<PetToy> toyInventory = new List<PetToy>();
                Console.Clear();

            Console.WriteLine();
                             Console.SetCursorPosition(50, 5); 

        Console.WriteLine(" ######                  #######");
                         Console.SetCursorPosition(50, 6); 

        Console.WriteLine(" #     # ###### #####       #     ####  #   #  ####  ");
                         Console.SetCursorPosition(50, 7); 

        Console.WriteLine(" #     # #        #         #    #    #  # #  #      ");
                         Console.SetCursorPosition(50, 8); 

        Console.WriteLine(" ######  #####    #         #    #    #   #    ####  ");
                         Console.SetCursorPosition(50, 9); 

        Console.WriteLine(" #       #        #         #    #    #   #        # ");
                         Console.SetCursorPosition(50, 10); 

        Console.WriteLine(" #       #        #         #    #    #   #   #    # ");
                         Console.SetCursorPosition(50, 11); 

        Console.WriteLine(" #       ######   #         #     ####    #    ####    \n\n");
            foreach (PetItem PetItem in inventory)
            {
                if (PetItem.GetType() == typeof(PetToy))
                {
                    PetToy inventoryToyPetItem = (PetToy)PetItem;
                    toyInventory.Add(inventoryToyPetItem);
                }
            }

            if (toyInventory.Count == 0)
            {
                                 Console.SetCursorPosition(50, 12); 

                Console.WriteLine("Unfortunately there are no toys available. You need to purchase some more from the store");
            }
            else
            {
                foreach (PetToy toy in toyInventory)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item Name: {toy.NameOfItem}");
                    Console.WriteLine($"Number of uses left: {toy.NumberOfUses}");
                    Console.WriteLine($"Press the number on the keyboard to select one, 0 is always the first number.");

                }

                int userStringSelection;

                Console.WriteLine("Please choose your preferred toy: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                PetToy userSelectedPetItem = toyInventory.ElementAt(userStringSelection);

                if (userSelectedPetItem.NumberOfUses - 1 < 0)
                {
                    Console.WriteLine($"Unfortunately {userSelectedPetItem.NameOfItem} is unfortunaly broken. You need to purchase some more from the store");
                    toyInventory.Remove(userSelectedPetItem);
                    inventory.Remove(userSelectedPetItem);
                }
                else
                {
                    pet.PlayWithToy(userSelectedPetItem);
                }
            }
        }

        public void DisplayMedicine(Pet pet)
        {
            List<Medicine> medicineInventory = new List<Medicine>();
                Console.Clear();

            Console.WriteLine();
                     Console.SetCursorPosition(50, 5); 

        Console.WriteLine(" #     #                                        ");
                 Console.SetCursorPosition(50, 6); 

        Console.WriteLine(" ##   ## ###### #####  #  ####  # #    # ###### ");
                 Console.SetCursorPosition(50, 7); 

        Console.WriteLine(" # # # # #      #    # # #    # # ##   # #      ");
                 Console.SetCursorPosition(50, 8); 

        Console.WriteLine(" #  #  # #####  #    # # #      # # #  # #####  ");
                 Console.SetCursorPosition(50, 9); 

        Console.WriteLine(" #     # #      #    # # #      # #  # # #      ");
                 Console.SetCursorPosition(50, 10); 

        Console.WriteLine(" #     # #      #    # # #    # # #   ## #      ");
                 Console.SetCursorPosition(50, 11); 

        Console.WriteLine(" #     # ###### #####  #  ####  # #    # ###### \n\n");
            foreach (PetItem PetItem in inventory)
            {
                if (PetItem.GetType() == typeof(Medicine))
                {
                    Medicine medicineInventoryPetItem = (Medicine)PetItem;
                    medicineInventory.Add(medicineInventoryPetItem);
                }
            }

            if (medicineInventory.Count == 0)
            {
                                 Console.SetCursorPosition(50, 12); 

                Console.WriteLine("Unfortunately there is no medicine available");
            }
            else
            {
                foreach (Medicine medicine in medicineInventory)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item Name: {medicine.NameOfItem}");
                    Console.WriteLine($"Number of uses left: {medicine.NumberOfUses}");
                    Console.WriteLine($"Press the number on the keyboard to select one, 0 is always the first number.");
                }

                int userStringSelection;

                Console.WriteLine("Please choose your preferred medicine: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Medicine userSelectedPetItem = medicineInventory.ElementAt(userStringSelection);

                if (userSelectedPetItem.NumberOfUses - 1 < 0)
                {
                    Console.WriteLine($"Unfortunately {userSelectedPetItem.NameOfItem} has now ran out. You need to purchase some more from the store");
                    medicineInventory.Remove(userSelectedPetItem);
                    inventory.Remove(userSelectedPetItem);
                }
                else
                {
                    pet.TakeMedicine(userSelectedPetItem);
                }
            }
            
        }
          public void DisplaySleep(Pet pet)
        {
            List<Sleep> sleepInventory = new List<Sleep>();
                Console.Clear();

            Console.WriteLine();
                             Console.SetCursorPosition(50, 5); 

        Console.WriteLine(" #####                              ");
                         Console.SetCursorPosition(50, 6); 

        Console.WriteLine("#     # #      ###### ###### #####  ");
                         Console.SetCursorPosition(50, 7); 

        Console.WriteLine("#       #      #      #      #    #");
                         Console.SetCursorPosition(50, 8); 

        Console.WriteLine(" #####  #      #####  #####  #    #");
                         Console.SetCursorPosition(50, 9); 

        Console.WriteLine("      # #      #      #      #####  ");
                         Console.SetCursorPosition(50, 10); 

        Console.WriteLine("#     # #      #      #      #      ");
                         Console.SetCursorPosition(50, 11); 

        Console.WriteLine(" #####  ###### ###### ###### #       \n\n");
            foreach (PetItem PetItem in inventory)
            {
                if (PetItem.GetType() == typeof(Sleep))
                {
                    Sleep sleepInventoryPetItem = (Sleep)PetItem;
                    sleepInventory.Add(sleepInventoryPetItem);
                }
            }

            if (sleepInventory.Count == 0)
            {
                                 Console.SetCursorPosition(50, 12); 

                Console.WriteLine("Unfortunately there is no sleep available. You need to purchase some more from the store");
            }
            else
            {
                foreach (Sleep sleep in sleepInventory)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Item Name: {sleep.NameOfItem}");
                    Console.WriteLine($"Number of uses left: {sleep.NumberOfUses}");
                    Console.WriteLine($"Press the number on the keyboard to select one, 0 is always the first number.");

                }

                int userStringSelection;

                Console.WriteLine("Please choose your preferred sleep length: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Sleep userSelectedPetItem = sleepInventory.ElementAt(userStringSelection);

                if (userSelectedPetItem.NumberOfUses - 1 < 0)
                {
                    Console.WriteLine($"{userSelectedPetItem.NameOfItem} has now ran out. You need to purchase some more from the store");
                    sleepInventory.Remove(userSelectedPetItem);
                    inventory.Remove(userSelectedPetItem);
                }
                else
                {
                    pet.GoToSleep(userSelectedPetItem);
                }
            }
            
        }
    }
}