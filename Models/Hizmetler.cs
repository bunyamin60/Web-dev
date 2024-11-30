namespace WebÖdev.Models
{
    public class Hizmetler
    {

        public int HizmetlerId { get; set; }
        public string HizmetName { get; set; }
        public int HizmetSuresi { get; set; }
        public int HizmetFiyat { get; set; }

        public ICollection<Randevu> Randevular { get; set; }
    }
}
