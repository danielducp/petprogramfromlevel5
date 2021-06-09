using System;
using System.Threading;
namespace PetSimulation
{

  public enum ApplicationState //Program States
        {
            RunTheProgram,
            ShopForItems,
            Food,
            Medicine,
            Toys, Sleep,
            PauseTheProgram,
            ExitTheProgram
        }
    class PetSimulationProgram
    {
        ApplicationState applicationstate = ApplicationState.RunTheProgram;
        int UserPetChoice;
       


        string UserPetName;
        double UserPetPreferredTemperature;


        PetShop shop = new PetShop();
        User user = new User(50); //Current number of coins when starting the program
         RoomEnvironment roomenvironment = new RoomEnvironment(18.0); //Target room temperature
        Pet pet;
        public PetSimulationProgram()
        {
            
        }

        public void Initialise()
        {
                          Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour   
            Console.CursorVisible = false;
            Console.Clear();
            pet = PetSeletionMenu();
         
        }

        public void Run()
        {
            Initialise();

            do
            {
                CheckKeyInputFromUser();

                switch (applicationstate)
                {
                    case ApplicationState.RunTheProgram:
                        Console.Clear();                                                user.Update();
                       user.Update();
                       roomenvironment.UpdateCurrentTemperature();
                        pet.UpdatePetTemperature(roomenvironment);
                        pet.Update();
                        pet.DisplayPetInformation();
                                           Console.SetCursorPosition(50, 20); 

                            pet.LiveTemperature(roomenvironment);
                    
            
                                           Console.SetCursorPosition(50, 22); 
                                           user.DisplayCurrentNumberOfCoins();
                    Console.WriteLine("\n");
                        DrawMainMenu();
          

                        break;
                    case ApplicationState.PauseTheProgram:
                    DisplayHelp();
                     pet.Update();

                        break;
                    case ApplicationState.ShopForItems:
                        Console.Clear();
                        pet.Update();
                   
                        DrawMainMenu();
                        
                        
                        Console.WriteLine();
                        shop.PrintShoppingList(user);
                             user.DisplayCurrentNumberOfCoins();
                        pet.DisplayPetInformation();
                        applicationstate = ApplicationState.RunTheProgram;
                        break;
                    case ApplicationState.Food:
                        user.inventory.DisplayFood(pet);
                        pet.Update();
                        applicationstate = ApplicationState.RunTheProgram;
                        break;
                    case ApplicationState.Medicine:
                        user.inventory.DisplayMedicine(pet);
                        pet.Update();
                        applicationstate = ApplicationState.RunTheProgram;
                        break;
                    case ApplicationState.Toys:
                        user.inventory.DisplayToy(pet);
                        pet.Update();
                        applicationstate = ApplicationState.RunTheProgram;
                        break;
                         case ApplicationState.Sleep:
                        user.inventory.DisplaySleep(pet);
                        pet.Update();
                        applicationstate = ApplicationState.RunTheProgram;
                        break;
                    case ApplicationState.ExitTheProgram:
                        break;
                    default:
                        break;
                }
                
                
                Thread.Sleep(10000/10);
            } while (applicationstate != ApplicationState.ExitTheProgram);
        }
        public Pet PetSeletionMenu() //Shows the pet selection menu
        {                   
                     Console.SetCursorPosition(50, 5); 
    
            Console.WriteLine(" #     #                                           ");
                     Console.SetCursorPosition(50, 6); 

            Console.WriteLine(" #  #  # ###### #       ####   ####  #    # ###### ");
                     Console.SetCursorPosition(50, 7); 

            Console.WriteLine(" #  #  # #      #      #    # #    # ##  ## #      ");
                     Console.SetCursorPosition(50, 8); 

            Console.WriteLine(" #  #  # #####  #      #      #    # # ## # #####  ");
                     Console.SetCursorPosition(50, 9); 

            Console.WriteLine(" #  #  # #      #      #      #    # #    # #      ");
                     Console.SetCursorPosition(50, 10); 

            Console.WriteLine(" #  #  # #      #      #    # #    # #    # #      ");
                     Console.SetCursorPosition(50, 11); 

            Console.WriteLine("  ## ##  ###### ######  ####   ####  #    # ###### \n\n");
         Console.SetCursorPosition(50, 12); 

            Console.WriteLine("Please press a number to choose your preferred pet: ");
                     Console.SetCursorPosition(50, 13); 

            Console.WriteLine("1)   Dog");
                     Console.SetCursorPosition(50, 14); 

            Console.WriteLine("2)   Cat");
                     Console.SetCursorPosition(50, 15); 

            Console.WriteLine("3)   Rabbit");
                     Console.SetCursorPosition(50, 16); 

            Console.WriteLine("4)   Hamster");
                     Console.SetCursorPosition(50, 17); 

            Console.WriteLine("5)   Guinea Pig");
                     Console.SetCursorPosition(50, 18); 

            Console.WriteLine("0)   Exit");
                           Console.SetCursorPosition(50, 20); 
         

                            bool validInput=false;

              do
                    {
                        try
                        {
                                                       Console.SetCursorPosition(50, 20); 

   UserPetChoice = Convert.ToInt32(Console.ReadLine());
                               if(UserPetChoice==0 || UserPetChoice==1 || UserPetChoice==2|| UserPetChoice==3|| UserPetChoice==4|| UserPetChoice==5)
                            {
                                validInput=true;
                            }
                            else
                            {
                                                           Console.SetCursorPosition(50, 21); 

                                Console.WriteLine("Option not available please try again");
                            }
                        }catch(Exception)
                        {
                            Console.SetCursorPosition(50, 21); 
                            Console.WriteLine("Not a valid option. Please try again");
                        }
                }while(!validInput);
            
            if (UserPetChoice == 1) //If user presses 1 choose dog
            {
                                                 Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                 Console.SetCursorPosition(50, 10); 
                 Console.WriteLine("Enter a name: ");
                Console.SetCursorPosition(50, 11); 
               
                UserPetName = Console.ReadLine();//Enter name for dog
                 Console.SetCursorPosition(50, 12); 
                               Console.WriteLine("Enter a temperature: "); 
                
                Console.SetCursorPosition(50, 13); 
            UserPetPreferredTemperature = Convert.ToDouble(Console.ReadLine());//Enter temperature for dog
                Console.Clear();
                Pet pet = new Pet(TypeOfPet.Dog, UserPetName, UserPetPreferredTemperature); //Create an instance of the dog

                return(pet);
                
            } 
            else if (UserPetChoice == 2)
            { 
                                                 Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.Clear();
          Console.WriteLine("Enter a name: ");   
         UserPetName = Console.ReadLine();
         Console.WriteLine("Enter a temperature: ");
                
            UserPetPreferredTemperature = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Pet pet = new Pet(TypeOfPet.Cat, UserPetName, UserPetPreferredTemperature);
            return(pet);
            }
            else if (UserPetChoice == 3)
            {     
                     Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour    
            Console.Clear();
            Console.WriteLine("Enter a name: ");
            UserPetName = Console.ReadLine();
            Console.WriteLine("Enter a temperature: ");
            UserPetPreferredTemperature = Convert.ToDouble(Console.ReadLine());                
            Console.Clear();
                Pet pet = new Pet(TypeOfPet.Rabbit, UserPetName, UserPetPreferredTemperature);
                return(pet);
            }
            else if (UserPetChoice == 4)
            {          
                                                 Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("Enter a name: ");
 UserPetName = Console.ReadLine();
                               Console.WriteLine("Enter a temperature: ");
                
               
            UserPetPreferredTemperature = Convert.ToDouble(Console.ReadLine());                Console.Clear();
                Pet pet = new Pet(TypeOfPet.Hamster, UserPetName, UserPetPreferredTemperature);
                return(pet);
            }
        else if (UserPetChoice == 5)
            {       
                      Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour   
                Console.Clear();
                Console.WriteLine("Enter a name: ");
 UserPetName = Console.ReadLine();
                               Console.WriteLine("Enter a temperature: ");
                
               
            UserPetPreferredTemperature = Convert.ToDouble(Console.ReadLine());                Console.Clear();
                Pet pet = new Pet(TypeOfPet.GuineaPig, UserPetName, UserPetPreferredTemperature);
                return(pet);
            }
             else if (UserPetChoice == 0)
            {       
                Exit();
                return(pet);
            }
            else
            {
                                        
 return null;
            }
        }
        

        public void CheckKeyInputFromUser() //Checks what key is pressed by the user
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Q)
                {
                    applicationstate = ApplicationState.ExitTheProgram; //Quit program
                }

                if (keyPressed == ConsoleKey.F)
                {
                    applicationstate = ApplicationState.Food; //Let pet eat
                }

                 if (keyPressed == ConsoleKey.L)
                {
                    applicationstate = ApplicationState.Sleep; //Let pet sleep
                }

                if (keyPressed == ConsoleKey.P)
                {
                    applicationstate = ApplicationState.Toys; //Let pet play with toy
                }

                if (keyPressed == ConsoleKey.M)
                {
                    applicationstate = ApplicationState.Medicine; //Feed pet medicine
                }

                if (keyPressed == ConsoleKey.S)
                {
                    applicationstate = ApplicationState.ShopForItems; //Shop for items
                }

                  if (keyPressed == ConsoleKey.Z) //Load Menu
                {
                    Console.Clear();
                    PetSeletionMenu();
                    
                }


                if (keyPressed == ConsoleKey.RightArrow)
                {
                    if (applicationstate != ApplicationState.PauseTheProgram)
                    {
                        applicationstate = ApplicationState.PauseTheProgram;
                    }
                    else if (applicationstate == ApplicationState.PauseTheProgram)
                    {
                        applicationstate = ApplicationState.RunTheProgram;
                    }
                }

                if (keyPressed == ConsoleKey.UpArrow)//Heat Room
                {
                    roomenvironment.HeatTheRoom(); 
                }

                if (keyPressed == ConsoleKey.DownArrow)//Cool Room
                {
                    roomenvironment.CoolTheRoom(); 
                }
            }
        }

        public void DrawMainMenu() //Menu on each pet screen
        {

                                               Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;  //Changes the console text colour       
            Console.WriteLine();
                           Console.SetCursorPosition(50, 23); 
            Console.WriteLine($"S: Shop for some items for {UserPetName}"); //{UserPetName} provides personalisation
                                      Console.SetCursorPosition(50, 24); 
            Console.WriteLine($"F: Give {UserPetName} some food");
                                      Console.SetCursorPosition(50, 25); 
            Console.WriteLine($"P: Play with {UserPetName}");
                                      Console.SetCursorPosition(50, 26); 
            Console.WriteLine($"M: Give {UserPetName} some medicine");
                                      Console.SetCursorPosition(50, 27); 
                                                 Console.WriteLine($"L: Let {UserPetName} sleep");
                                                 Console.SetCursorPosition(50, 28); 
            Console.WriteLine($"Right: Pause");
                                       Console.SetCursorPosition(50, 29); 
            Console.WriteLine($"Up:  Heat up the room for {UserPetName}");
                                      Console.SetCursorPosition(50, 30); 
            Console.WriteLine($"Down: Cool down the room for {UserPetName}");
                                      Console.SetCursorPosition(50, 31); 
            Console.WriteLine($"L: Let {UserPetName} sleep");
                                       Console.SetCursorPosition(50, 32); 
            Console.WriteLine("Q: Quit");
                                                                           Console.SetCursorPosition(50, 33); 

            Console.WriteLine("Z: Go back to the main menu");

        }

             public void DisplayHelp() //Help menu when the simulation is paused
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
                  Console.WriteLine("");
                           Console.SetCursorPosition(50, 5); 

            Console.WriteLine("#     #                          #####                                     ");
                     Console.SetCursorPosition(50, 6); 

            Console.WriteLine("#     # ###### #      #####     #     #  ####  #####  ###### ###### #    # ");
                     Console.SetCursorPosition(50, 7); 

            Console.WriteLine("#     # #      #      #    #    #       #    # #    # #      #      ##   # ");
                     Console.SetCursorPosition(50, 8); 

            Console.WriteLine("####### #####  #      #    #     #####  #      #    # #####  #####  # #  #");
                     Console.SetCursorPosition(50, 9); 

            Console.WriteLine("#     # #      #      #####           # #      #####  #      #      #  # #");
                     Console.SetCursorPosition(50, 10); 

            Console.WriteLine("#     # #      #      #         #     # #    # #   #  #      #      #   ##");
                     Console.SetCursorPosition(50, 11); 

            Console.WriteLine("#     # ###### ###### #          #####   ####  #    # ###### ###### #    # ");
                     Console.SetCursorPosition(50, 13); 

                  Console.WriteLine("Press the corrosponding keys on they keyboard to interact with the pet...");
                           Console.SetCursorPosition(50, 14); 

            Console.WriteLine("Press Any key to Continue");
                                Console.SetCursorPosition(50, 15);
            Console.ReadKey(true);
            applicationstate = ApplicationState.RunTheProgram;
                                 Console.BackgroundColor = ConsoleColor.Black; //Changes the console background colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }

        public void Exit() //Exit the program
        {    System.Environment.Exit(1);
        }


    }
}