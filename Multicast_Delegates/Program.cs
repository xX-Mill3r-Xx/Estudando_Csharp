using System;
using Services;

namespace Multicast_Delegates
{
    #region Delegate
    delegate void BinaryNumericOperation(double n1, double n2);
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            /*
             Multicast delegates
                • Delegates que guardam a referência para mais de um método
                • Para adicionar uma referência, pode-se usar o operador +=
                • A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados
                • Seu uso faz sentido para métodos void
             */

            #region Demo
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
            #endregion
        }
    }
}
