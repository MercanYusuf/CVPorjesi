using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YusufCv.Models
{
    [Table("Proje")]
    public class Proje
    {
        [Key]
        public int ProjeId { get; set; }
        public string Aciklama { get; set; }
    }
}