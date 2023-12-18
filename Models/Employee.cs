using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codefirsteg
{
   public class Employee
    {
        [Key]
        public int Eid{get;set;}
        
        [Required(ErrorMessage ="Employee Name is Required")]
        [Display(Name ="Employee Name")]
        public string Ename{get;set;}

        [Range(minimum:5000,maximum:15000,ErrorMessage ="Salary should be between 5k and 15k")]
        public float Salary{get;set;}
        [Required(ErrorMessage="Please Enter Email Id")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter Valid Email")]
        public string EmailId{get;set;}

        [StringLength(maximumLength:10,MinimumLength =10,ErrorMessage ="Phone number should be exact 10 digits")]
        public string ContactNumber{get;set;}
        [DataType(DataType.Date,ErrorMessage ="Invalid Date")]
        public DateTime DOB{get;set;}

        [Required(ErrorMessage ="Password is Mandatory")]
        public string Password{get;set;}

        [NotMapped]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword{get;set;}
        
    }
}