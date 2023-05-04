using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Sample.Models
{
    public class Customer
    {
        #region Data

        [Key]
        [Display(Name = "ID")]
        public string Cus_id { get; set; }

        [Required(ErrorMessage = "Customer Name is required")]
        [Display(Name = "Customer Name ")]
        public string Cus_name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        [DataType(DataType.MultilineText)]
        public string Cus_addresss { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Cus_email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Cus_password { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        [RegularExpression(@"^(\+?\d{8,15})$", ErrorMessage = "Invalid Contact Number. Please enter a valid phone number in the format +[country code][phone number] or [phone number] with no spaces.")]
        public string Cus_phonenumber { get; set; }


        #endregion


        #region Supporting


        public string ReturnURL { get; set; } = "/SampleCategory/Index";

        #endregion


    

    }

    public class CustomerSearchView
    {
        public string APIKey { get; set; }

        public string KeyW { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<V_Number_Temp> DataList = new List<V_Number_Temp>();
        public List<int> PaginationList = new List<int>();
    }
}
