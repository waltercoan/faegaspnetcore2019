using System.Threading.Tasks;
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
        
    }
}