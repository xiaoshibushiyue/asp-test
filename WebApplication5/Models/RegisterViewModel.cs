using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="邮箱地址有误")]
        [RegularExpression("",ErrorMessage ="邮箱地址")]
        
        public string Email { get; set; }
        [Required(ErrorMessage = "有误")]

        public string Password { get; set; }
        [Required(ErrorMessage = "有误")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Range(10,20,ErrorMessage ="年龄必须在10-20之间")]
        [Display(Name ="年龄")]
        public int Age { get; set; }

        public  DateTime? BornData { get; set; }
             
    }
}