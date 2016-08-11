using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace CustomPaging.Models
{
    public class Studentinfo
    {
        public List<Studentinform> Studentmodel { get; set; }
    }

    [Table("Tbl")]
    public class Studentinform
    {
        public int Id { get; set; }
        public string Name { get; set; }          
        public string Address { get; set; }
        public int marks { get; set; }
    }
}