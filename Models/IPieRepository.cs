using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyShop.Models
{
   public interface IPieRepository
    {
        IEnumerable<Pie> GetPies();
        Pie GetPieById(int id);
    }
}
