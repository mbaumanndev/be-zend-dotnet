using System.ComponentModel.DataAnnotations;

namespace MBaumann.ConfNet.WebMvc.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
