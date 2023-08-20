using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class degree
    {
        [Key]
        [Column("degree_id")]
        public int DegreeId { get; set; }
        [Column("degree_name")]
        public string DegreeName { get; set; }
    }
}
