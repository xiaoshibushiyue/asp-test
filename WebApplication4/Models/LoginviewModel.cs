using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class LoginviewModel
    {
        [EmailAddress(ErrorMessage ="邮件名有误")]
        [Display(Name ="电子邮件")]
        [Required,StringLength(10,MinimumLength =2)]
        public string name { get; set; }
        [Required, StringLength(10, MinimumLength = 2)]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Email { get; set; }

    }
}