using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class StudentListViewModel
    {
        
            public List<student> Students { get; set; }
            public int CurrentPage { get; set; }
            public int TotalPages { get; set; }

    }
}
