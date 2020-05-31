using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;
        public PieRepository(AppDbContext context)
        {
            _context = context;
                
        }
        public Pie GetPieById(int id)
        {
            var pie = _context.Pies.SingleOrDefault(p => p.PieId == id);
            return pie;
        }

        public IEnumerable<Pie> GetPies()
        {
            var pies = _context.Pies.ToList();
            return pies;
        }
    }
}
