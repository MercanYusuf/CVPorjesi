using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YusufCv.Models
{
    [Table("Sosyal Medya")]
    public class SosyalMedya
    {
        [Key]
        public int SosyalId { get; set; }
        [DisplayName("Email"), StringLength(150)]
        public string Email { get; set; }
        [DisplayName("Telefon")]
        public string Telefon { get; set; }
        [DisplayName("Linked"),StringLength(150)]
        public string Linked { get; set; }
        [DisplayName("GitHub"), StringLength(150)]
        public string GitHub { get; set; }
        [DisplayName("Twitter"), StringLength(150)]
        public string Twitter { get; set; }
        [DisplayName("Facebook"), StringLength(150)]
        public string Facebook { get; set; }
        [DisplayName("Instagram"), StringLength(150)]
        public string Instagram { get; set; }
    }
}