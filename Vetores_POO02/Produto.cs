

namespace Vetores_POO02
{
    class Produto
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; private set; }


        public double AddPrice(double value)
        {
            return ProductPrice = value;
        }
    }
}
