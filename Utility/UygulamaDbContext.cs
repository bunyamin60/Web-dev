using Microsoft.EntityFrameworkCore;
using WebÖdev.Models;

namespace WebÖdev.Utility
{
    public class UygulamaDbContext :DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }

        public DbSet<Salonlar> Salonlar { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
       

    }
}
