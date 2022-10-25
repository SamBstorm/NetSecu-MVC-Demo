using System.ComponentModel.DataAnnotations;

namespace MaPremiereAppMVC.Models.ModelViews
{
    public class AuthLoginForm
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est obligatoire")]
        [MinLength(4,ErrorMessage ="Le nom d'utilisateur n'a pas assez de caractères")]
        [MaxLength(16, ErrorMessage = "Le nom d'utilisateur a trop de caractères")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [MinLength(8, ErrorMessage = "Le mot de passe n'a pas assez de caractères")]
        [MaxLength(32, ErrorMessage = "Le mot de passe a trop de caractères")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\-=+@.*#]).{8,32}$", ErrorMessage = "Le mot de passe ne correspond pas au format attendu...")]
        public string Password { get; set; }
    }
}
