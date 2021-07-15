using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6.Models
{
   
    public class Registeration
    {
       
        [Required(ErrorMessage = "FirstName is Required")]
        public string fName { get; set; }
        [Required(ErrorMessage ="MiddleName is Required")]
        public string mName { get; set; }
        [Required(ErrorMessage = "LastName is Required")]
        public string lName { get; set; }
        [Required]
        public string Month { get; set; }
        [Required]
        public int? Date { get; set; }
        [Required]
        public int? Year { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        public string StreetAddress1 { get; set; }
       [Required]
       [RegularExpression(@"\w{0,10}@[a-z]{3,6}(\.)[a-z]{2,3}", ErrorMessage = "Enter the crct format")]
        public string EMail { get; set; }
        [Required]
        [RegularExpression(@"^[9,8]{1}[0-9]{9}$", ErrorMessage = "Enter the crct format")]
        public string PhoneNumber { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string PositionApplied { get; set; }
        public string LinkedIn { get; set; }
        public string Aboutus { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public DateTime? AppStartDate { get; set; }
        public string CoverLetter { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{6}$")]
        public string PinCode { get; set; }
       
    }
}
