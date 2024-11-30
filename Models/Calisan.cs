using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebÖdev.Models
{
    public class Calisan
    {
        public int CalisanId { get; set; }

        [Required]
        public string CalisanAdi { get; set; }
        public string UzmanlikAlani { get; set; }   
        public string UygunlukSaatleri { get; set; }
        [ForeignKey("Salon")]
        public int SalonId { get; set; }

        // Navigation Property
        public Salonlar Salon { get; set; }

        public ICollection<Randevu> Randevular { get; set; }
    }
}
