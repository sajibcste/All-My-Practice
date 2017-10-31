using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelper.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "provide your name")]
        [StringLength(10,ErrorMessage = "string length must be less tahn 10")]
        public String Name { get; set; }
         [Required(ErrorMessage = "provide your Email")]
        
        public string Email { get; set; }
         [Required(ErrorMessage = "provide your Gender")]
         [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",ErrorMessage = "please provide valid email")]
        public string Gender { get; set; }
         [Required(ErrorMessage = "provide your Department")]
        public string Department { get; set; }
         [Required(ErrorMessage = "provide your Address")]
        public string Address { get; set; }
         [Required(ErrorMessage = "provide your Password")]
        public string Password  { get; set; }
         [Required(ErrorMessage = "confirm password")]
        public string ConfirmPassword { get; set; }
    }
}