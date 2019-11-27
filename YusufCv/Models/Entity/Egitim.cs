using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YusufCv.Models
{
    [Table("Eğitim Bilgiler")]
    public class Egitim
    {
        [Key]
        public int EgitimId { get; set; }
        public string Baslik { get; set; }
        [Required]
        public string Aciklama { get; set; }
       

    
    }
}