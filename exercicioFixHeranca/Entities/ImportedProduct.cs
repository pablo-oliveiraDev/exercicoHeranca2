


namespace exercicioFixHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
    }
    public ImportedProduct()
    {

    }

    public ImportedProduct(string name, double price, double customsFee) : base( name, price)
    {
         CustomsFee = customsFee;
    }
}
