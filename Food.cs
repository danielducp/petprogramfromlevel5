namespace PetSimulation
{
    class Food : PetItem //Inherits from PetItem
    {

public int DecreaseHunger;
public int IncreaseHappiness;

        public Food(string NameOfItem, int CostOfPetItem, int NumberOfUses, int DecreaseHunger, int IncreaseHappiness) : base (NameOfItem, CostOfPetItem, NumberOfUses)
        {
            this.NameOfItem = NameOfItem; //Inherited from PetItem

            this.CostOfPetItem = CostOfPetItem;//Inherited from PetItem

            this.NumberOfUses = NumberOfUses;//Inherited from PetItem

            this.DecreaseHunger = DecreaseHunger;
            this.IncreaseHappiness = IncreaseHappiness;
        }


    }
}
