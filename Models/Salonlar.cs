namespace WebÖdev.Models
{
    public class Salonlar
    {
        public int Id { get; set; }
        public string SalonAdi { get; set; }
        public string CalismaSaatleri {  get; set; }   
        public string SalonAdres {  get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }

    }
}
