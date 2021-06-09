namespace PetSimulation
{



        abstract class PetItem
    {
        public string NameOfItem { get; set; }
        public int CostOfPetItem { get; set; }
        public int NumberOfUses { get; set; }

        public PetItem(string NameOfItem, int CostOfPetItem, int NumberOfUses)
        {
            this.NameOfItem = NameOfItem;
            this.CostOfPetItem = CostOfPetItem;
            this.NumberOfUses = NumberOfUses;
        }
    }
}


