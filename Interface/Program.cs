using System;
using System.Globalization;
using InterfaceE.Entities;
using InterfaceE.Services;

namespace InterfaceE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Interface
                Interface é um tipo que define um conjunto de operações que uma
                classe (ou struct) deve implementar.

            A interface estabelece um contrato que a classe (ou struct) deve cumprir.
            Pra quê interfaces?
                • Para criar sistemas com baixo acoplamento e flexíveis.
             */

            /*
                Problema exemplo
                Uma locadora brasileira de carros cobra um valor por hora para locações de até
                12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será
                cobrada com base em um valor diário. Além do valor da locação, é acrescido no
                preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%
                para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um
                programa que lê os dados da locação (modelo do carro, instante inicial e final da
                locação), bem como o valor por hora e o valor diário de locação. O programa
                deve então gerar a nota de pagamento (contendo valor da locação, valor do
                imposto e valor total do pagamento) e informar os dados na tela. Veja os
                exemplos.
             */

            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string car = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime devolution = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(pickup, devolution, new Veicle(car));

            RentalServices rentalServices = new RentalServices(pricePerHour, pricePerDay, new BrazilTaxService());
            rentalServices.ProcessInvoice(carRental);
            
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);

            Console.ReadLine();
            /*
                Calculations:
                Duration = (25/06/2018 14:40) - (25/06/2018 10:30) = 4:10 = 5 hours 
                Basic payment = 5 * 10 = 50
                Tax = 50 * 20% = 50 * 0.2 = 10
             */
        }
    }
}
