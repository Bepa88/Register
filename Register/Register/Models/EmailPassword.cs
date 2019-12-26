using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterWeb.Models
{
    public class EmailPassword
    {
        [EmailAddress]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 char")]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [System.ComponentModel.DefaultValue("")]
        public string Email { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 char")]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [System.ComponentModel.DefaultValue("")]
        public string Password { get; set; }
    }
}