﻿using System.Globalization;

namespace InterfaceE.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        //Propiedade calculada;
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment: ${BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: ${Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total Payment: ${TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
