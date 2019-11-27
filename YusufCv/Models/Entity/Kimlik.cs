using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YusufCv.Models
{
    [Table("Kişisel Kimlik")]
    public class Kimlik
    {
        [Key]

        public int KimlikId { get; set; }
        [DisplayName("Adınız"),StringLength(10)]
        public string Ad { get; set; }
        [DisplayName("Soyadınız"), StringLength(10)]
        public string Soyad { get; set; }
        [DisplayName("Ünvan"), StringLength(50)]
        public string Unvan { get; set; }
        public string ResimURL { get; set; }  

    }
}