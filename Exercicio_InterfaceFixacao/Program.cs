﻿using System;
using System.Globalization;
using Exercicio_InterfaceFixacao.Entities;
using Exercicio_InterfaceFixacao.Services;

namespace Exercicio_InterfaceFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Uma empresa deseja automatizar o processamento de seus contratos. O processamento de
                um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no
                número de meses desejado.
                A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.
                Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa
                por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica
                juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.
                Fazer um programa para ler os dados de um contrato (número do contrato, data do contrato,
                e valor total do contrato). Em seguida, o programa deve ler o número de meses para
                parcelamento do contrato, e daí gerar os registros de parcelas a serem pagas (data e valor),
                sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois
                meses após o contrato e assim por diante. Mostrar os dados das parcelas na tela.
             */

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

            Console.ReadLine();
        }
    }
}
