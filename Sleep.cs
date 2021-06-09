namespace PetSimulation
{
     class Sleep : PetItem //Inherits from PetItem
    {
   public int IncreaseHappiness;
      public int IncreaseHunger;
      public int DecreaseTiredness;


        public Sleep(string NameOfItem, int CostOfPetItem, int NumberOfUses, int IncreaseHappiness, int IncreaseHunger, int DecreaseTiredness)  : base (NameOfItem, CostOfPetItem, NumberOfUses)
        {
           this.NameOfItem = NameOfItem; //Inherited from PetItem

            this.CostOfPetItem = CostOfPetItem;//Inherited from PetItem

            this.NumberOfUses = NumberOfUses;//Inherited from PetItem


            this.IncreaseHappiness = IncreaseHappiness;
                      
            this.IncreaseHunger = IncreaseHunger;
            this.DecreaseTiredness = DecreaseTiredness;

        }
     
    }
}