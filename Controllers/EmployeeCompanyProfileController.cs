using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeCompanyProfileController : Controller
    {

        private readonly ApplicationDbContext _context;
        public EmployeeCompanyProfileController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listOfEmp = _context.EmployeeCompanyProfile.Take(4).ToList();
            return View(listOfEmp);
        }
    }
}
