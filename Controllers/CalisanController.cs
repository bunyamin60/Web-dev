using Microsoft.AspNetCore.Mvc;
using WebÖdev.Models;
using WebÖdev.Utility;

namespace WebÖdev.Controllers
{
    public class CalisanController : Controller
    {
        private readonly UygulamaDbContext _uygulamaDbContext;

        public CalisanController(UygulamaDbContext context)
        {
            _uygulamaDbContext = context;
        }
        public IActionResult Index()
        {
            List<Calisan> objCalisanList = _uygulamaDbContext.Calisanlar.ToList();
            return View(objCalisanList);  
        }
    }
}
