using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Membros Estaticos, tambem chamados de membros de classe, em oposição a membros e instancia;

            São membros que fazem sentido independente de objetos, não precisão de objetos para serem chamados,
            são chamados apartir do propio nome da classe;

            Aplicações comum:
             - Classes Utilitarias
             - Declaração de constantes

            Uma classe que possui apenas membros estaticos, pode ser uma classe estatica tambem.
            Esta classe não podera ser instanciada;

            Exercicio Exemplo.:

            Fazer um programa para ler um numero qualquer, e dai mostrar quanto seria o valor de uma circunferencia
            e do volume de uma esfera para o raio daquele valor. informar tambem o valor de PI com duas casas decimais.
             */

            Console.Write("Entre com o valor do raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferencia = {Esfera.Circ(r).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume = {Esfera.Volume(r).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi = {Esfera.PI.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
