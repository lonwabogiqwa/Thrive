using System.ComponentModel.DataAnnotations;

namespace Thrive.Web.Common.ViewModels
{
  public  class LoginViewModel
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; }

    }
}
