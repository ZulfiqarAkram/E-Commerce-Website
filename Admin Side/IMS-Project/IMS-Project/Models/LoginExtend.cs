using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IMS_Project.Models
{
    [MetadataType(typeof(LoginMetaData))]
    public partial class Login
    {
    }
    public class LoginMetaData
    {
        [Required(ErrorMessage="Please enter username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}