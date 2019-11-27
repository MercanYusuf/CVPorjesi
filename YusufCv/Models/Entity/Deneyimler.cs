using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace YusufCv.Models
{
    [Table("Deneyimler")]
    public class Deneyimler
    {
        [Key]
        public int DeneyimId { get; set; }

        public string DeneyimAd { get; set; }
        public string DeneyimAciklama { get; set; }

        public string Sertifika { get; set; }

        public string SertifikaAciklama { get; set; }

        public DateTime Tarih { get; set; }
    }
}