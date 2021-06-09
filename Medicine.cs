namespace PetSimulation
{
     class Medicine : PetItem //Inherits from PetItem
    {
      public int IncreaseHealth;
            public int IncreaseHunger;


        public Medicine(string NameOfItem, int CostOfPetItem, int NumberOfUses, int IncreaseHealth, int IncreaseHunger) : base (NameOfItem, CostOfPetItem, NumberOfUses)
        {
            this.NameOfItem = NameOfItem; //Inherited from PetItem

            this.CostOfPetItem = CostOfPetItem;//Inherited from PetItem

            this.NumberOfUses = NumberOfUses;//Inherited from PetItem

            this.IncreaseHealth = IncreaseHealth;
            this.IncreaseHunger = IncreaseHunger;
        }
  
    }
}