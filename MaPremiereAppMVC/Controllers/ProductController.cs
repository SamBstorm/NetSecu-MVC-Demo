using MaPremiereAppMVC.Models;
using MaPremiereAppMVC.Models.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace MaPremiereAppMVC.Controllers
{
    public class ProductController : Controller
    {
        [ViewData]
        public string Title { get => $"Shopping{_subtitle}"; }
        private string _subtitle = "";
        public IActionResult Index()
        {
            return RedirectToAction(nameof(List));
        }

        public IActionResult List()
        {
            _subtitle = ", faîtes votre choix!";
            //ViewData["Title"] = "Toto"; // Il sera écrasé par l'attribut du ViewData
            Console.WriteLine($"Affiche le contenu de ViewData : {ViewData["Title"] ?? "Null"}");
            ProductListView model = new ProductListView() {
                Products = new List<Product>() {
                    new Product(){ Name = "Porte-clé", Price = 2.5M, Stock=20},
                    new Product(){ Name = "Cable USB", Price = 12.5M, Stock=10},
                    new Product(){ Name = "Bouteille d'eau", Price = 1M, Stock=30},
                    new Product(){ Name = "Console de jeu", Price = 299.99M, Stock=0}
                }
            };

            return View(model);
        }
    }
}
