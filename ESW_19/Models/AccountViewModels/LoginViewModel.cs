using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESW_19.Models.AccountViewModels
{
    public class LoginViewModel
    {
        // Metódo que recebe o email do utilizador e faz a validação da mesma
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //Metódo que recebe a password do utilizador e faz a validação da mesma
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //Metód que permite o utilizador memorizar a password 
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
