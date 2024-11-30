using System.ComponentModel.DataAnnotations.Schema;

namespace WebÖdev.Models
{
    public class Randevu
    {
        public int RandevuId { get; set; }


        
        public string MusteriName { get; set; }
        public int CalisanId { get; set; }

        public int  HizmetId { get; set; }

        public DateTime RandevuZamani { get; set; }
        public string RandevuDurumu {  get; set; }

        // Navigation Properties
        [ForeignKey("CalisanId")]
        public Calisan Calisan { get; set; }    // Çalışanla ilişki

        [ForeignKey("HizmetId")]
        public Hizmetler Hizmet { get; set; }      // Hizmetle ilişki

    }
}
