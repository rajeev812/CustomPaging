using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomPaging.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Studentinform> stTbl { get; set; }
    }
}