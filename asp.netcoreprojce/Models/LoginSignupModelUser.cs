using System.ComponentModel.DataAnnotations;

namespace asp.netcoreprojce.Models
{
    public class LoginSignupModelUser
    {
        [Display(Name ="İsim Soyisim")]
        [Required(ErrorMessage ="Lütfen İsim ve Soyisim Gİriniz")]
        public string Name_SureName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifre Uyuşmiyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail giriniz")]
        public string Email { get; set; }

        [Display(Name = "Kulanıcı Adı")]
        [Required(ErrorMessage = "Kulanıcı Adı giriniz")]
        public string UserName { get; set; }

    }
}
