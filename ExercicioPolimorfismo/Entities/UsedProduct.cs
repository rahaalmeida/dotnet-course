using System;
using System.Globalization;

namespace ExercicioPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nameProduct, double price, DateTime manufactureDate)
            : base (nameProduct, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return NameProduct
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
