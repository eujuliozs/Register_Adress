using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Register_with_address.Models;
using Register_with_address.Models.Service;
using Register_with_address.Models.ViewModel;
using System.Diagnostics;

namespace Register_with_address.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaSerivce _pessoaSerivce;
        public PessoasController(PessoaSerivce pessoaSerivce) 
        { 
            _pessoaSerivce = pessoaSerivce;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public IActionResult CreateConfirm(Pessoa pessoa)
        {
            if (!ModelState.IsValid) 
            {
                return View(pessoa);
            }
            try
            {
                _pessoaSerivce.Insert(pessoa);
            }
            catch(ApplicationException ex)
            {
                return RedirectToAction(nameof(Error), new { Message = ex.Message });
            }

            return RedirectToAction("Index", "Enderecos", pessoa);
        }
        public IActionResult Error(string message)
        {
            ErrorViewModel viewModel= new()
            {
                Message=message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            };
            return View(viewModel);
        }
    }
}
