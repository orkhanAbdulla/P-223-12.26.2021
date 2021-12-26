using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presento.DAL;
using Presento.Models;
using Presento.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //List<CardCategory> cardCategory = _context.CardCategories.Include(c => c.Card).Include(c => c.Category).ToList();
            HomeVM homeVM = new HomeVM()
            {
                Employees = _context.Employees.Include(x => x.Socials).ToList(),
                Categories = _context.Categories.Include(x => x.CardCategories).ThenInclude(x=>x.Card).ToList()
                
            };
            return View(homeVM);
        }
    }
}
