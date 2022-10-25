using MaPremiereAppMVC.Models.ModelViews;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace MaPremiereAppMVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Login));
        }
        //[HttpGet] pas nécessaire car par défaut
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Login(IFormCollection collection)
        public IActionResult Login(AuthLoginForm form)
        {

            //ValidateLoginForm(form); //Validation Manuelle du ModelState (plus d'actualité)
            ValidatePassword(form);
            if (!ModelState.IsValid) return View();
            //Vérifie en DB si Username + Password sont OK,
            //si OUI: RedirectToAction("Index","Home")
            //si NON: return View();
            return View();
        }

        /** Validation Manuelle du ModelState (plus d'actualité)
        private void ValidateLoginForm(AuthLoginForm form)
        {
            if (form is null) throw new ArgumentNullException(nameof(form));
            if (String.IsNullOrEmpty(form.Username))
                ModelState.AddModelError(nameof(form.Username), "Le nom d'utilisateur est obligatoire");
            if (String.IsNullOrEmpty(form.Password))
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe est obligatoire");
            if (form.Password?.Length < 8)
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe n'a pas assez de caractères");
            if (form.Password?.Length > 32)
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe a trop de caractères");
        }
        */

        private void ValidatePassword(AuthLoginForm form)
        {
            string password = form.Password;
            string min_pattern = @"[a-z]+";
            string maj_pattern = @"[A-Z]+";
            string numb_pattern = @"[0-9]+";
            string symb_pattern = @"[@\-+=#_]+";
            if (!Regex.IsMatch(password, min_pattern, RegexOptions.None))
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe ne contient pas de minuscule.");
            if (!Regex.IsMatch(password, maj_pattern, RegexOptions.None))
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe ne contient pas de majuscule.");
            if (!Regex.IsMatch(password, numb_pattern, RegexOptions.None))
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe ne contient pas de chiffre.");
            if (!Regex.IsMatch(password, symb_pattern, RegexOptions.None))
                ModelState.AddModelError(nameof(form.Password), "Le mot de passe ne contient pas de symbole.");
        }
    }
}
