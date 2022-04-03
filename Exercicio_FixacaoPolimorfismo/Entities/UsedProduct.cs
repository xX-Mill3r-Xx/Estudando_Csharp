using System;
using System.Globalization;

namespace Exercicio_FixacaoPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return $"Used:{Name}, ${Price.ToString("F2",CultureInfo.InvariantCulture)}, Manufacture date: {Date.ToString("dd/MM/yyyy")}";
        }

    }
}
