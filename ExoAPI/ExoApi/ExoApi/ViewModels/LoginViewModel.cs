using System.ComponentModel.DataAnnotations;

namespace ExoApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Requirido")]
    
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Necessária")]
        public string Senha { get; set; }
    }
}
