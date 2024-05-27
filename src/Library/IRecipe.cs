namespace Full_GRASP_And_SOLID
{
    public interface IRecipe
    {
        Product FinalProduct { get; set; }
        void AddStep(Product input, double quantity, Equipment equipment, int time);
        void AddStep(string description, int time);
        void RemoveStep(BaseStep step);
        string GetTextToPrint();
        double GetProductionCost();
    }
}