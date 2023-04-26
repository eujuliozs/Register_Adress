using Microsoft.AspNetCore.Mvc;
using Register_with_address.Models;
using Register_with_address.Models.Service;

namespace Register_with_address.Controllers
{
    public class EnderecosController : Controller 
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Pessoa pessoa)
        {
            return View(pessoa.Id);
        }
    }
}
