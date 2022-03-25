using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POOAplicado01
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Quantity;

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

    }
}
