using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class student
    {
        [Key]
        [Column("student_id")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please Provide First Name!")]
        [Display(Name ="First Name")]
        [Column("first_name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Provide Last Name!")]
        [Display(Name = "Last Name")]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Provide Date of Birth!")]
        [Display(Name = "Date of Birth")]
        [Column("date_of_birth")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Please Provide Email!")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide Phone Number!")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Provide Address!")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Provide Gender!")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Provide Major!")]
        [Display(Name = "Major")]
        public string Major { get; set; }

        [Column("degree_id")]
        
        
        public int DegreeId { get; set; }


        [NotMapped]
        public string Degree { get; set; }
    }
}
