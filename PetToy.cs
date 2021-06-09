




namespace PetSimulation
{
     class PetToy : PetItem //Inherits from PetItem
    {
   public int IncreaseHappiness;
      public int IncreaseHunger;


        public PetToy(string NameOfItem, int CostOfPetItem, int NumberOfUses, int IncreaseHappiness, int IncreaseHunger)  : base (NameOfItem, CostOfPetItem, NumberOfUses)
        {
                   this.NameOfItem = NameOfItem; //Inherited from PetItem

            this.CostOfPetItem = CostOfPetItem;//Inherited from PetItem

            this.NumberOfUses = NumberOfUses;//Inherited from PetItem

            this.IncreaseHappiness = IncreaseHappiness;
                      
            this.IncreaseHunger = IncreaseHunger;

        }
     
    }
}