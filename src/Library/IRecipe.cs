namespace Full_GRASP_And_SOLID
{
    public interface IRecipe // esta interfas tiene varios metodos de recipe pero no todos son nesesarios para que consoleprinter no dependa de recipe
    {  
        Product FinalProduct { get; set; }
        void AddStep(Product input, double quantity, Equipment equipment, int time);
        void AddStep(string description, int time);
        void RemoveStep(BaseStep step);
        string GetTextToPrint();//este metodo si es necesario
        
        double GetProductionCost();
    }
}