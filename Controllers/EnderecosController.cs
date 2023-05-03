using Microsoft.AspNetCore.Mvc;
using Register_with_address.Models;
using Register_with_address.Models.Service;

namespace Register_with_address.Controllers
{
    public class EnderecosController : Controller 
    {
        private readonly CepService _cepService;
        private readonly EndereçoService _endereçoService;
        public EnderecosController(CepService cepService, EndereçoService EndereçoService) 
        {
            _endereçoService = EndereçoService;
            _cepService = cepService;
        }
        public IActionResult Index()
        {
            List<Endereço> endereços = _endereçoService.FindAll();
            return View(endereços);
        }
        public IActionResult Create(string? Cep)
        {
            if (Cep == null)
            {
                return View(new Endereço());
            }

            var endereço = _cepService.GetCepInfo(Cep);
            ViewData["Cep"] = endereço.Result.Cep;
            ViewData["Logradouro"] = endereço.Result.Logradouro;
            ViewData["Bairro"] = endereço.Result.Bairro;
            ViewData["Complemento"] = endereço.Result.Complemento;
            ViewData["Localidade"] = endereço.Result.Localidade;
            ViewData["Uf"] = endereço.Result.Uf;
            return View(new Endereço());
            
        }

        [HttpPost]
        [ActionName("Create")] 
        public IActionResult CreateConfirm(Endereço endereço)
        {
            _endereçoService.Insert(endereço);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Endereço? endereço = _endereçoService.FindById(id);
            return View(endereço);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _endereçoService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id, string? Cep)
        {
            Endereço? _endereço = _endereçoService.FindById(id.Value);
            if (Cep != null)
            {
                _endereço.Cep = Cep;
            }   
            var CepInfo = _cepService.GetCepInfo(_endereço.Cep);
            ViewData["Cep"] = CepInfo.Result.Cep;
            ViewData["Logradouro"] = CepInfo.Result.Logradouro;
            ViewData["Bairro"] = CepInfo.Result.Bairro;
            ViewData["Complemento"] = CepInfo.Result.Complemento;
            ViewData["Localidade"] = CepInfo.Result.Localidade;
            ViewData["Uf"] = CepInfo.Result.Uf;
            return View(_endereço);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditConfirm(int? id, Endereço? endereço)
        {
            if(id.Value == null)
            {
                return BadRequest();
            }
            _endereçoService.Update(endereço);
            return RedirectToAction(nameof(Index));
        }

    }
}
