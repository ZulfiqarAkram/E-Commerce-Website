using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMS_Project.Models
{
    [MetadataType(typeof(SupplierMetaData))]
    public partial class Supplier
    {
    }
    public class SupplierMetaData
    {
        [Display(Name="ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Company Name")]
        [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains only Alphabets")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Person")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains only Alphabets")]
        public string ContactName { get; set; }

        [Display(Name = "Person Title")]
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Required,DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    
    }
}