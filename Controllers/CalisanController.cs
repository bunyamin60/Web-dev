using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
       

        public IActionResult CalisanEkle() 
        {
            

            return View(); 
        
        }
        [HttpPost] 
        public IActionResult CalisanEkle(Calisan calisan)
        {

            _uygulamaDbContext.Calisanlar.Add(calisan);
            _uygulamaDbContext.SaveChanges();

            return RedirectToAction("Index","Calisan");
        }

    }
}
