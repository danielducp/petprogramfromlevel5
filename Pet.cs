using System;
namespace PetSimulation
{


    public enum TemperatureStatistics //The output for how hot the pet feels
    {
        TooCold, TooHot, JustRight
    }
    class Pet
    {
                private readonly TypeOfPet typeOfPet;
        public string NameOfPet { get; }
        int CurrentMoodLevel;
        int CurrentHungerLevel;
        int CurrentHealthLevel;
        int CurrentTirednessLevel;
        public double PetsIdealTemperature { get; }
        TemperatureStatistics temperatureStatistics;
        
    
        string image;
    public Pet(TypeOfPet typeOfPet, string nameOfPet, double petsIdealTemperature) 
    {
        this.typeOfPet=typeOfPet;
        PetsIdealTemperature = petsIdealTemperature;
        NameOfPet = nameOfPet;
        CurrentMoodLevel = 85; //Default Pet Mood Value
        CurrentHealthLevel = 99; //Default Pet Health Value
        CurrentHungerLevel = 5;//Default Pet Hunger Value
        CurrentTirednessLevel = 0; //Default Pet Tiredness Value
        image = "";
        
    }

    public void DisplayPetInformation()
    {
         Console.SetCursorPosition(50, 5); 
        Console.WriteLine(" ######                   #####                                     ");
                Console.SetCursorPosition(50, 6); 
        Console.WriteLine(" #     # ###### #####    #     #  ####  #####  ###### ###### #    # ");
        Console.SetCursorPosition(50, 7); 
        Console.WriteLine(" #     # #        #      #       #    # #    # #      #      ##   # ");
               Console.SetCursorPosition(50, 8); 
        Console.WriteLine(" ######  #####    #       #####  #      #    # #####  #####  # #  # ");
                Console.SetCursorPosition(50, 9); 
        Console.WriteLine(" #       #        #            # #      #####  #      #      #  # # ");
                Console.SetCursorPosition(50, 10); 
        Console.WriteLine(" #       #        #      #     # #    # #   #  #      #      #   ## ");
                Console.SetCursorPosition(50, 11); 
        Console.WriteLine(" #       ######   #       #####   ####  #    # ###### ###### #    # \n\n");
                       Console.SetCursorPosition(50, 13); 
        Console.WriteLine(NameOfPet + " is a "+Convert.ToString(typeOfPet)) ;
                       Console.SetCursorPosition(50, 14); 
        Console.WriteLine($"{NameOfPet}'s current Mood Level is: {CurrentMoodLevel} ") ; //Outputs current mood
                       Console.SetCursorPosition(50, 15); 
        Console.WriteLine($"{NameOfPet}'s current Health Level is: {CurrentHealthLevel} ") ; //Outputs current health level
                       Console.SetCursorPosition(50, 16); 
        Console.WriteLine($"{NameOfPet}'s current Hunger Level is: {CurrentHungerLevel} ") ;//Outputs current hunger level
                               Console.SetCursorPosition(50, 17); 
        Console.WriteLine($"{NameOfPet}'s current Tiredness Level is: {CurrentTirednessLevel} ") ; //Outputs current health level
                       Console.SetCursorPosition(50, 18); 
        Console.WriteLine($"At the moment {NameOfPet} is {temperatureStatistics}"); //Outputs whether pet is too hot, just right or too cold
                       Console.SetCursorPosition(50, 19); 
        Console.WriteLine($"The pets ideal temperature is: {PetsIdealTemperature}"); //Outputs ideal temperature for the pet

    }

    public void Update()
        {

            
            if (CurrentHungerLevel > 50) //Decreases the health level if above 50
            {
                if (CurrentHealthLevel >0)
                {
                CurrentHealthLevel --;}
                else CurrentHealthLevel = 0;
            }
            
            if (CurrentHungerLevel + 1 <= 100) //Increases hunger level upto 100
            {
                CurrentHungerLevel ++;
            }

            if (CurrentTirednessLevel + 1 <= 100) //Increases tiredness level upto 100
            {
                CurrentTirednessLevel ++;
            }

            if (CurrentMoodLevel - 1 >= 0) //Decreses mood level
            {
                CurrentMoodLevel--;
            }
        }

        public void UpdatePetTemperature(RoomEnvironment roomenvironment)
                
{
                    if (roomenvironment.roomtemperature > PetsIdealTemperature + 2.0)
            {
                temperatureStatistics = TemperatureStatistics.TooHot; //Pet says it is too hot if above by 2 and decreases health
               if (CurrentHealthLevel >0)
                {
                CurrentHealthLevel --;}
                else CurrentHealthLevel = 0;
            
            }
            else if (roomenvironment.roomtemperature < PetsIdealTemperature - 2.0)
            {
                temperatureStatistics = TemperatureStatistics.TooCold;//Pet says it is too cold if above by 2 and decreases health
                if (CurrentHealthLevel >0)
                {
                CurrentHealthLevel --;}
                else CurrentHealthLevel = 0;
            
            }
            else
            {
                temperatureStatistics = TemperatureStatistics.JustRight; //Pet says it is just right
            }
         
        }
   public void LiveTemperature(RoomEnvironment roomenvironment)
            {
                                       Console.SetCursorPosition(50, 20); 
                          roomenvironment.roomtemperature = Math.Round(roomenvironment.roomtemperature, 2);

                    Console.WriteLine($"The live temperature is: {roomenvironment.roomtemperature }");  //Outputs live temperature

            }
        public void EatFood(Food food) //If food is eaten, decrease hunger, increase mood and take a use
        {
            if (CurrentHungerLevel - food.DecreaseHunger < 0)
            {
                CurrentHungerLevel = 0;
            }
            else
            {
                CurrentHungerLevel -= food.DecreaseHunger;
            }

                      if (CurrentMoodLevel - food.IncreaseHappiness > 100)
            {
                CurrentMoodLevel = 100;
            }
            else
            {
                CurrentMoodLevel += food.IncreaseHappiness;
            }
            food.NumberOfUses --;
        }

        public void TakeMedicine(Medicine medicine) //If medicine is taken, increase health, increase hunger and take a use
        {
            if (CurrentHealthLevel + medicine.IncreaseHealth > 100)
            {
                CurrentHealthLevel = 100;
            }
            else
            {
                CurrentHealthLevel+= medicine.IncreaseHealth;
            }

            if (CurrentHungerLevel + medicine.IncreaseHunger > 100)
            {
                CurrentHungerLevel = 100;
            }
            else
            {
                CurrentHungerLevel += medicine.IncreaseHunger;
            }

            medicine.NumberOfUses --;
        }

        public void PlayWithToy(PetToy pettoy) //If toy is played with, increase happiness, increase hunger and take use
        {
            if(CurrentMoodLevel + pettoy.IncreaseHappiness > 100)
            {
                CurrentMoodLevel = 100;
            }
            
            else
            {
                CurrentMoodLevel += pettoy.IncreaseHappiness;
            }

                 if(CurrentHungerLevel + pettoy.IncreaseHunger > 100)
            {
                CurrentHungerLevel = 100;
            }
            
            else
            {
                CurrentHungerLevel += pettoy.IncreaseHunger;
            }
            pettoy.NumberOfUses --;   
        }

        public void GoToSleep(Sleep sleep) //If pet goes to sleep, increase happiness, increase hunger, decrease tiredness and take use
    {
      if(CurrentMoodLevel + sleep.IncreaseHappiness > 100)
            {
                CurrentMoodLevel = 100;
            }
            
            else
            {
                CurrentMoodLevel += sleep.IncreaseHappiness;
            }

                 if(CurrentHungerLevel + sleep.IncreaseHunger > 100)
            {
                CurrentHungerLevel = 100;
            }
            
            else
            {
                CurrentHungerLevel += sleep.IncreaseHunger;
            }

             if(CurrentTirednessLevel - sleep.DecreaseTiredness <= 0)
            {
                CurrentTirednessLevel = 0;
            }
            
            else
            {
                CurrentTirednessLevel -= sleep.DecreaseTiredness;
            }
                        sleep.NumberOfUses --;   

    }

}
}
