using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Produto()
        {
        }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Produto(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalEmEstoque()
        {
            double total = Quantity * Price;
            return total;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return $"Dados Atualizados: {Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Total: ${TotalEmEstoque()}";
        }
    }
}
