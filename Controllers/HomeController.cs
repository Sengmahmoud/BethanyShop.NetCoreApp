using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanyShop.Models;

namespace BethanyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
      
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository =pieRepository;
        }
        // GET: /Home/
        public IActionResult Index()
        {
            var pies=_pieRepository.GetPies();
            return View(pies);
        }
        // GET: /Home/Details/{id}
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            else
                return View(pie);

        }
    }
}