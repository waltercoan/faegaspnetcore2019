using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using empresaapp.Models;
using empresaapp.Services;
using Microsoft.AspNetCore.Mvc;


namespace empresaapp.Controllers
{
    public class ClientController : Controller
    {
        public IClientService ClientService;

        public ClientController(IClientService ClientService)
        {
            this.ClientService = ClientService;
        }
        public async Task<IActionResult> Index()
        {
            var _listClient = await this.ClientService.GetAll();
            return View(_listClient);
        }
        [HttpGet]
        public IActionResult Form()
        {
            var client = new Client();
            return View(client);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var client = await this.ClientService.GetById(Id);
            return View("Form",client);
        }
        
        [HttpPost]
        public IActionResult Form(Client client)
        {
            if (ModelState.IsValid)
            {
                this.ClientService.Save(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}