using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioFixHeranca.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return base.Name + " (used) $ " + base.Price + "(Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + " )";
        }
    }
}
