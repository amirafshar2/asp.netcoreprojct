using System.ComponentModel.DataAnnotations;

namespace asp.netcoreprojce.Models
{
    public class UserSignİnView
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
