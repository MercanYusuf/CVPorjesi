using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace YusufCv.Models
{
    [Table("Programlama Dilleri ")]
    public class ProgramalamaDili
    {
        [Key]
        public int ProgramlamaId { get; set; }

        public string Programalama { get; set; }
    }
}