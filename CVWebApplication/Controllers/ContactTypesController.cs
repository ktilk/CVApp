using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;
using DAL.Interfaces;
using Domain;

namespace CVWebApplication.Controllers
{
    public class ContactTypesController : Controller
    {
        private readonly IContactTypeRepository _repo;

        public ContactTypesController(IContactTypeRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var r = _repo.All.Count();
            ViewData["Message"] = $"There are {r} types in db.";
            return View();
        }
    }
}