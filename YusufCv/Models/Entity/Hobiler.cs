using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YusufCv.Models
{
    [Table("Hobiler")]
    public class Hobiler
    {
        [Key]
        public int HobilerId { get; set; }
        public string Aciklama { get; set; }
    }
}