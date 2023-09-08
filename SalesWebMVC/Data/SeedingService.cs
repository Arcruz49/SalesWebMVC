using SalesWebMVC.Models;
using System;
using SalesWebMVC.Models.Enums;
using System.Linq;


namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Sellers.Any() ||
                _context.SalesRecords.Any())
            {
                return; //DB already seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department { Id = 4, Name = "Books" };

            Seller s1 = new Seller(1,"Michael Scott","michael@gmail.com",new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2,"Phillis","phillis@gmail.com",new DateTime(1979, 12, 31), 1000.0, d2);
            Seller s3 = new Seller(3,"Dwight","dwigth@gmail.com",new DateTime(1999, 2, 11), 1000.0, d3);
            Seller s4 = new Seller(4,"Pam","pam@gmail.com",new DateTime(2000, 9, 22), 1000.0, d4);
            Seller s5 = new Seller(5,"Jim","jim@gmail.com",new DateTime(2000, 1, 05), 1000.0, d1);
            Seller s6 = new Seller(6,"Stanley","stanley@gmail.com",new DateTime(1965, 5, 27), 1000.0, d2);

            SalesRecord record1 = new SalesRecord(1, new DateTime(2023, 8, 1), 500.0, SaleStatus.Cancelado,s1);
            SalesRecord record2 = new SalesRecord(2, new DateTime(2023, 8, 2), 750.0, SaleStatus.Faturado,s2);
            SalesRecord record3 = new SalesRecord(3, new DateTime(2023, 8, 3), 1000.0, SaleStatus.Pendente,s3);
            SalesRecord record4 = new SalesRecord(4, new DateTime(2023, 8, 4), 300.0, SaleStatus.Faturado,s4);
            SalesRecord record5 = new SalesRecord(5, new DateTime(2023, 8, 5), 1200.0, SaleStatus.Faturado,s5);
            SalesRecord record6 = new SalesRecord(6, new DateTime(2023, 8, 6), 800.0, SaleStatus.Pendente,s6);
            SalesRecord record7 = new SalesRecord(7, new DateTime(2023, 8, 7), 950.0, SaleStatus.Cancelado,s1);
            SalesRecord record8 = new SalesRecord(8, new DateTime(2023, 8, 8), 600.0, SaleStatus.Pendente,s2);
            SalesRecord record9 = new SalesRecord(9, new DateTime(2023, 8, 9), 1100.0, SaleStatus.Cancelado,s3);
            SalesRecord record10 = new SalesRecord(10, new DateTime(2023, 8, 10), 400.0, SaleStatus.Faturado,s4);
            SalesRecord record11 = new SalesRecord(11, new DateTime(2023, 8, 11), 550.0, SaleStatus.Pendente,s5);
            SalesRecord record12 = new SalesRecord(12, new DateTime(2023, 8, 12), 720.0, SaleStatus.Faturado,s6);
            SalesRecord record13 = new SalesRecord(13, new DateTime(2023, 8, 13), 950.0, SaleStatus.Faturado,s1);
            SalesRecord record14 = new SalesRecord(14, new DateTime(2023, 8, 14), 350.0, SaleStatus.Faturado,s2);
            SalesRecord record15 = new SalesRecord(15, new DateTime(2023, 8, 15), 1300.0, SaleStatus.Pendente,s3);
            SalesRecord record16 = new SalesRecord(16, new DateTime(2023, 8, 16), 870.0, SaleStatus.Faturado,s1);
            SalesRecord record17 = new SalesRecord(17, new DateTime(2023, 8, 17), 800.0, SaleStatus.Pendente,s2);
            SalesRecord record18 = new SalesRecord(18, new DateTime(2023, 8, 18), 700.0, SaleStatus.Cancelado,s4);
            SalesRecord record19 = new SalesRecord(19, new DateTime(2023, 8, 19), 900.0, SaleStatus.Cancelado,s5);
            SalesRecord record20 = new SalesRecord(20, new DateTime(2023, 8, 20), 420.0, SaleStatus.Faturado,s6);
            SalesRecord record21 = new SalesRecord(21, new DateTime(2023, 8, 21), 530.0, SaleStatus.Pendente,s3);
            SalesRecord record22 = new SalesRecord(22, new DateTime(2023, 8, 22), 670.0, SaleStatus.Pendente,s4);
            SalesRecord record23 = new SalesRecord(23, new DateTime(2023, 8, 23), 820.0, SaleStatus.Pendente,s5);
            SalesRecord record24 = new SalesRecord(24, new DateTime(2023, 8, 24), 230.0, SaleStatus.Faturado,s6);
            SalesRecord record25 = new SalesRecord(25, new DateTime(2023, 8, 25), 1500.0, SaleStatus.Faturado,s1);
            SalesRecord record26 = new SalesRecord(26, new DateTime(2023, 8, 26), 920.0, SaleStatus.Pendente,s2);
            SalesRecord record27 = new SalesRecord(27, new DateTime(2023, 8, 27), 1050.0, SaleStatus.Faturado,s3);
            SalesRecord record28 = new SalesRecord(28, new DateTime(2023, 8, 28), 480.0, SaleStatus.Pendente,s4);
            SalesRecord record29 = new SalesRecord(29, new DateTime(2023, 8, 29), 600.0, SaleStatus.Faturado,s5);
            SalesRecord record30 = new SalesRecord(30, new DateTime(2023, 8, 30), 320.0, SaleStatus.Pendente,s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Sellers.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(record1,record2,record3,record4,record5,record6,record7,record8,record9,record10,
                record11,record12,record13,record14,record15,record16,record17,record18,record19,record20,record21,record22,
                record23,record24,record25,record26,record27,record28,record29,record30);

            _context.SaveChanges();

        }
    }
}
