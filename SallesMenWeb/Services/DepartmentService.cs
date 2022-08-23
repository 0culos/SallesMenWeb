using SallesMenWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesMenWeb.Services
{
    public class DepartmentService
    {
        private readonly SallesMenWebContext _context;

        public DepartmentService(SallesMenWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() // sincronização assíncrona da função
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); // await usado para avisar o compilador que essa chamada será assíncrona
        }

    }
}
