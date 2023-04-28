using Microsoft.AspNetCore.Mvc;
using Register_with_address.Models;
using Register_with_address.Models.Service;

namespace Register_with_address.Controllers
{
    public class EnderecosController : Controller 
    {
        private readonly CepService endereçoService;
        public EnderecosController(CepService Service) 
        {
            endereçoService = Service;
        }
        public IActionResult Index(string? Cep)
        {
            
            if(Cep == null)
            {
                return View(new Endereço());
            }

            var endereço = endereçoService.GetCepInfo(Cep);
            ViewData["Cep"] = endereço.Result.Cep;
            ViewData["Logradouro"] = endereço.Result.Logradouro;
            ViewData["Bairro"] = endereço.Result.Bairro;
            ViewData["Complemento"] = endereço.Result.Complemento;
            ViewData["Localidade"] = endereço.Result.Localidade;
            ViewData["Uf"] = endereço.Result.Uf;
            return View(new Endereço());
            
        }
        public IActionResult Create(Pessoa pessoa)
        {
            return View(pessoa.Id);
        }
    }
}
