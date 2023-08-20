using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class studentContext : DbContext
    {
        public studentContext(DbContextOptions<studentContext> options): base(options)
        {
            
        }
        public DbSet<student> student { get; set; }
        public DbSet<degree> degrees { get; set; }
    }
}
