using Microsoft.EntityFrameworkCore;
using WebÖdev.Models;

namespace WebÖdev.Utility
{
    public class UygulamaDbContext :DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }

        public DbSet<Salonlar> Salonlar { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        // OnModelCreating metodu burada tanımlanır
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Burada ilişkileri tanımlıyoruz
            modelBuilder.Entity<Calisan>()
                .HasOne(c => c.Salon)
                .WithMany(s => s.Calisanlar)
                .HasForeignKey(c => c.SalonId); // Burada foreign key'i tanımlıyoruz

            // Diğer özel yapılandırmalarınızı buraya ekleyebilirsiniz
        }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
       

    }
}
