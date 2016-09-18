using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMS_Project.Models
{
    //[MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {
    }
    //public class CustomerMetaData
    //{
    //    [Display(Name="ID")]
    //    public int CustomerID { get; set; }

    //    [Required, RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains only Alphabets")]
    //    public string Name { get; set; }
        

    //    [Required,Display(Name="Type")]
    //    public int CustType { get; set; }

    //    [DataType(DataType.EmailAddress,ErrorMessage="Please enter correct email address")]
    //    public string Email { get; set; }
        
    //    [Required,DataType(DataType.PhoneNumber,ErrorMessage="Mobile number contains only Numbers")]        
    //    public string Mobile { get; set; }
        
    //    [Required, DataType(DataType.PhoneNumber, ErrorMessage = "Mobile number contains only Numbers")]
    //    public string Phone { get; set; }
        
    //    public string Address { get; set; }
        
    //    [Required]
    //    [Display(Name="Added By")]
    //    public int AddedBy { get; set; }
    
    //}
}