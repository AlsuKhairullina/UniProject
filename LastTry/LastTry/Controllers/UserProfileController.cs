using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LastTry.Controllers
{
    public class UserProfileController : Controller
    {
        private AppDBContext db;

        public UserProfileController(AppDBContext context)
        {
            db = context;
        }
        
        [HttpGet]
        public IActionResult Vacancies()
        {
        
            var vacancies = db.Vacancies.ToArray(); // Products
            return View(vacancies);
        }
        
        // GET
        public IActionResult Timetable()
        {
            return View();
        }
        
        public IActionResult Dormitory()
        {
            return View();
        }
    }
}