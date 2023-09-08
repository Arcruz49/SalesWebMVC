using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} necessário")]
        [Display(Name = "Nome")]
        [StringLength(60,MinimumLength = 3, ErrorMessage = "O nome deve ter mais de 3 caracteres")]
        public String Name { get; set; }

        [Required(ErrorMessage = "{0} necessário")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Display(Name = "Data de aniversário")]
        [Required(ErrorMessage = "{0} necessário")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "{0} necessário")]
        [Display(Name = "Salário")]
        [Range(0.00, 100000,ErrorMessage ="O salário deve ser entre {0} e {1}")]
        [DisplayFormat(DataFormatString ="R${0:f2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthdate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthdate = birthdate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
