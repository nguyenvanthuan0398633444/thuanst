using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Request
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập email !")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu !")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
