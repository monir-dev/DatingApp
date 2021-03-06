using System.Collections.Generic;
using System.Linq;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly DatabaseContext db;
        
        public BooksController(DatabaseContext db)
        {
            this.db = db;
        }
        
        [Authorize]
        // GET
        public IActionResult Index()
        {
            List<Makes> makes = db.Makes.ToList();
//            return View();
            return Json(makes);
        }
    }
}