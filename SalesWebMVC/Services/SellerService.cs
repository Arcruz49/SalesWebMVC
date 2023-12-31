﻿using SalesWebMVC.Models;
using System.Collections.Generic;
using SalesWebMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;


namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Sellers.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Sellers.Any(x => x.Id == obj.Id)) throw new NotFoundException("Id not found");
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex) { throw new DbConcurrencyException(ex.Message); }
        }
    }
}
