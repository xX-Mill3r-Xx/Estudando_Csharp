using System;

namespace InterferenciaDeTipos_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A palavra reservada var, infere a variavel o tipo a que ela sera atribuida;
             Exemplos:
            */

            var x = 10; //int
            var y = "Nome"; //string
            var z = 5.0; //double
            var w = 0.1f; //float

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}
