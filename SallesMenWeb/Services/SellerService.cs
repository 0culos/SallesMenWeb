using SallesMenWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesMenWeb.Services
{
    public class SellerService
    {
        private readonly SallesMenWebContext _context;

        public SellerService(SallesMenWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
