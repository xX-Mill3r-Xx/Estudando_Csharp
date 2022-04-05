using System;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIN { get; set; }
        public DateTime CheckOUT { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIN, DateTime checkOUT)
        {
            if (checkIN <= checkOUT)
            {
                throw new DomainExceptions("Error in reservation!");
            }
            RoomNumber = roomNumber;
            CheckIN = checkIN;
            CheckOUT = checkOUT;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOUT.Subtract(CheckIN);
            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                 throw new DomainExceptions("Error in reservation!");
            }
            if (checkin <= checkout)
            {
                throw new DomainExceptions("Error in reservation!");
            }

            CheckIN = checkin;
            CheckOUT = checkout;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, CheckIn: {CheckIN.ToString("dd/MM/yyyy")}, CheckOut: {CheckOUT.ToString("dd/MM/yyyy")}, Total Days: {Duration()} nights.";
        }
    }
}
