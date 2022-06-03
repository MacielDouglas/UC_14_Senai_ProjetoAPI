using System.ComponentModel.DataAnnotations;

namespace Chapter.WebApi2.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Necessária")]
        public string Senha { get; set; }
    }
}
