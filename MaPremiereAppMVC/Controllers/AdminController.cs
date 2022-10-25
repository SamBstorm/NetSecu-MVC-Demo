using MaPremiereAppMVC.Models;
using MaPremiereAppMVC.Models.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace MaPremiereAppMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Bienvenu");
        }

        [Route("Admin/new")]
        [Route("NewAdmin")]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Bienvenu()
        {
            AdminBienvenuView model = new AdminBienvenuView() {
                AdminContactMail = "info.admin@monSiteMVC.be"
            };
            model.AddAdmin(new Admin() { 
                FirstName = "Samuel", 
                LastName = "Legrain", 
                Email = "samuel.legrain@bstorm.be"
            });
            model.AddAdmin(new Admin() { 
                FirstName = "Thierry", 
                LastName = "Morre", 
                Email = "thierry.morre@cognitic.be" 
            });
            model.AddAdmin(new Admin() { 
                FirstName = "Michaël", 
                LastName = "Person", 
                Email = "michael.person@cognitic.be" 
            });
            model.AddAdmin(new Admin() { 
                FirstName = "Aude", 
                LastName = "Beurive", 
                Email = "aude.beurive@bstorm.be" 
            });
            return View(model);
        }

        public string codehtml()
        {
            return @"<!DOCTYPE HTML>
<html>
    <head>
        <title>Exemple de code html</title>
    </head>
    <body>
        <h1>Exemple de code html</h1>
    </body>
</html>";
        }

        public int[] tableauEntier(int id=10)
        {
            int[] ints = new int[id];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }
            return ints;
        }
    }
}
