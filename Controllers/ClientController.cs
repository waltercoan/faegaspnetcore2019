using System.Threading.Tasks;
using empresaapp.Models;
using empresaapp.Services;
using Microsoft.AspNetCore.Mvc;

namespace empresaapp.Controllers
{
    public class ClientController : Controller
    {
        private IClientService service = null;
        public ClientController(IClientService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var _listClient = await this.service.GetAll();
            return View(_listClient);
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var client = await service.GetById(Id);
            return View("Form",client);
        }
        
        [HttpPost]
        public IActionResult Form(Client client)
        {
            if (ModelState.IsValid)
            {
                service.Save(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}