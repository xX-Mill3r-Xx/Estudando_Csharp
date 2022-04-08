using System;

namespace InversaoEInjecaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             • Acoplamento forte
                • A classe RentalService conhece a dependência concreta
                • Se a classe concreta mudar, é preciso mudar a classe RentalService

            class RentalService {
                (...)
            private BrazilTaxService _brazilTaxService = new BrazilTaxService();
             */

            /*
             • Acoplamento fraco
                • A classe RentalService não conhece a dependência concreta
                • Se a classe concreta mudar, a classe RentalService não muda nada

            class RentalService {
                (...)
            private ITaxService _taxService;
             */

            /*
             Injeção de dependência por meio de construtor

            class Program {
            static void Main(string[] args) {
                (...)
                RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            class RentalService {

                private ITaxService _taxService;

                public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) {
                    PricePerHour = pricePerHour;
                    PricePerDay = pricePerDay;
                    _taxService = taxService;
            }
             */

            /*
             Inversão de controle
                • Inversão de controle
                Padrão de desenvolvimento que consiste em retirar da classe a
                responsabilidade de instanciar suas dependências.
                • Injeção de dependência
                É uma forma de realizar a inversão de controle: um componente externo
                instancia a dependência, que é então injetada no objeto "pai". Pode ser
                implementada de várias formas:
                • Construtor
                • Objeto de instanciação (builder / factory)
                • Container / framework
             */
        }
    }
}
