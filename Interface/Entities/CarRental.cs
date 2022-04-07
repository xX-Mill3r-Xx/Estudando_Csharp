using System;

namespace InterfaceE.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public Veicle Veicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Veicle veicle)
        {
            Start = start;
            Finish = finish;
            Veicle = veicle;
        }
    }
}
