using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace CVWebApplication.Controllers
{
    public class ContactTypesController : Controller
    {
        private readonly CVAppDbContext _dbContext;

        public ContactTypesController(CVAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var r = _dbContext.ContactTypes.Count();
            ViewData["Message"] = $"There are {r} types in db.";
            return View();
        }
    }
}