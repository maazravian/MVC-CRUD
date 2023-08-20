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
        [Column("first_name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Provide Last Name!")]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Provide Date of Birth!")]
        [Column("date_of_birth")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Please Provide Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide Phone Number!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Provide Address!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Provide Gender!")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Provide Major!")]
        public string Major { get; set; }

        [Column("degree_id")]
        
        
        public int DegreeId { get; set; }


        [NotMapped]
        public string Degree { get; set; }
    }
}
