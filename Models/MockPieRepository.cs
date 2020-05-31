using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;
        public MockPieRepository()
        {
                if(_pies ==null)
            {
                IntilaizePies();
            }
        }

        private void IntilaizePies()
        {
            _pies = new List<Pie>
            {

                //new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.",ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",IsPieOfTheWeek=false},
                //new Pie {PieId = 2, Name="Cheese cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.",ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", IsPieOfTheWeek=false},
                //new Pie {PieId = 3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.",ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",  IsPieOfTheWeek=true},
                //new Pie {PieId = 4, Name="Pumpkin Pie", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll.",ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",IsPieOfTheWeek=true}

            };

        }

        public Pie GetPieById(int id)
        {
            var pie = _pies.SingleOrDefault(p => p.PieId == id);
            return pie;
        }

        public IEnumerable<Pie> GetPies()
        {
            var pies = _pies.ToList();
            return pies;
        }
    }
}
