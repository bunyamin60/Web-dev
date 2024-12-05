using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebÖdev.Models
{
    public class Calisan
    {
        [Key]
        public int CalisanId { get; set; }

        [Required]
        [DisplayName("Çalışan Adı")]
        public string CalisanAdi { get; set; }
        [DisplayName("Uzmanlık Alanı")]
        public string UzmanlikAlani { get; set; }
        [DisplayName("İş Başı Saati")]
        public TimeSpan? UygunlukBaslangic { get; set; }
        [DisplayName("İş Bitiş Saati")]
        public TimeSpan? UygunlukBitis { get; set; }

         [ForeignKey("Salon")]
        public int SalonId { get; set; }

        // Navigation Property
        public Salonlar Salon { get; set; }

        public ICollection<Randevu> Randevular { get; set; }
    }
}
