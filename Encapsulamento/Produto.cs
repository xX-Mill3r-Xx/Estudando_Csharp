using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Produto
    {
        //Por padrao, os atributos passam a ser private e usam a convençao de nomeclatura do c#;
        private string _name;
        private double _price;
        private int _quantity;

        public Produto()
        {
        }

        public Produto(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        #region Geters AND Seters da classe
        //##################################################################################################################
        /*Para implementar um acessador para que a classe program tenha acesso ao atributo nome, fazemos da seguinte maneira;*/
        public string GetName()
        {
            return _name;
        }

        /*Para implementar um metodo para definir o nome de um atributo usamos o Set e implementamos da seguinte maneira;*/
        public void SetName(string name)
        {
            /*uma regra criada para controlar este metodo;
             Só sera possivel alterar o nome do produto se:
             - Não for nulo
             - O tamanho do nome for maior que 1 caracter;*/
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        /*
         Para o preço e a quantidade, criamos apenas o Metodo Get destes atributos, o que seguinifica que voce apena pode
        obter os dados e não definir.
         */

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        //##################################################################################################################
        #endregion

        public double TotalEmEstoque()
        {
            double total = _quantity * _price;
            return total;
        }

        public void AddProduct(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            _quantity -= quantity;
        }

        public override string ToString()
        {
            return $"Dados Atualizados: {_name}, ${_price.ToString("F2", CultureInfo.InvariantCulture)}, Total: ${TotalEmEstoque()}";
        }
    }
}
