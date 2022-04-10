using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; //O banco de dados ja foi populado;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Miller Vasco", "miller@mail.com", new DateTime(1990,09,27), 1500.00, d1);
            Seller s2 = new Seller(2, "Mateus Vasco", "mateus@mail.com", new DateTime(1995, 02, 21), 1500.00, d2);
            Seller s3 = new Seller(3, "Junior Vasco", "junior@mail.com", new DateTime(1988, 06, 27), 1500.00, d3);
            Seller s4 = new Seller(4, "Selma Vasco", "selma@mail.com", new DateTime(1977, 07, 18), 1500.00, d4);
            Seller s5 = new Seller(5, "Nilson Vasco", "nilson@mail.com", new DateTime(1960, 11, 30), 1500.00, d1);
            Seller s6 = new Seller(6, "Samuel Vasco", "samuel@mail.com", new DateTime(1995, 03, 28), 1500.00, d2);
            Seller s7 = new Seller(7, "Thais Vasco", "thais@mail.com", new DateTime(1990, 01, 03), 1500.00, d3);
            Seller s8 = new Seller(8, "Auxiliadora Vasco", "bocadefogo@mail.com", new DateTime(1940, 06, 18), 1500.00, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022,09,25), 11000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 09, 25), 10000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 09, 25), 15000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 09, 25), 21000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 09, 25), 20000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 09, 25), 31000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 09, 25), 17000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s7);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 09, 25), 14000.00, SalesWebMvc.Models.Enums.SeleStatus.Billed, s8);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6,s7,s8);
            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);

            _context.SaveChanges();

        }
    }
}
