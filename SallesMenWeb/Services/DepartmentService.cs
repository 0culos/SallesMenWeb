using SallesMenWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallesMenWeb.Services
{
    public class DepartmentService
    {
        private readonly SallesMenWebContext _context;

        public DepartmentService(SallesMenWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
