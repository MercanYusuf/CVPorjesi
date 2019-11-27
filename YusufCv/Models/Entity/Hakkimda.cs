using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace YusufCv.Models
{
    [Table("Hakkımda")]
    public class Hakkimda
    {
        [Key]
        public  int HakkimdaId { get; set; }
        public string Aciklama { get; set; }
   
    }
}