using System.Globalization;


namespace exercicioFixHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.Name + " $ "+ TotalPrice() + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + " )" ;
        }
        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }

    }
}
