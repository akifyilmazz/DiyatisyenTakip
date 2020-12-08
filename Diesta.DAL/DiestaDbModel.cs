namespace Diesta.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiestaDbModel : DbContext
    {
        public DiestaDbModel()
            : base("name=DiestaDbModel")
        {
        }

        public virtual DbSet<AnketSoru> AnketSoru { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<AnketTur> AnketTur { get; set; }
        public virtual DbSet<Danisan> Danisan { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<UyeHatirlatma> UyeHatirlatma { get; set; }
        public virtual DbSet<UyeIletisim> UyeIletisim { get; set; }
        public virtual DbSet<UyeOdeme> UyeOdeme { get; set; }
        public virtual DbSet<UyeRandevu> UyeRandevu { get; set; }
        public virtual DbSet<UyeSirket> UyeSirket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnketSoru>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<AnketSoru>()
                .Property(e => e.AnketTurId)
                .IsUnicode(false);

            modelBuilder.Entity<AnketSoru>()
                .Property(e => e.AnketSoru1)
                .IsUnicode(false);

            modelBuilder.Entity<AnketSoru>()
                .Property(e => e.AnketSoruCevap)
                .IsUnicode(false);

            modelBuilder.Entity<AnketTur>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<AnketTur>()
                .Property(e => e.AnketTurBaslik)
                .IsUnicode(false);

            modelBuilder.Entity<Danisan>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Danisan>()
                .Property(e => e.UyeId)
                .IsUnicode(false);

            modelBuilder.Entity<Uye>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Uye>()
                .Property(e => e.UyeUnvan)
                .IsUnicode(false);

            modelBuilder.Entity<Uye>()
                .Property(e => e.UyeMail)
                .IsUnicode(false);

            modelBuilder.Entity<Uye>()
                .Property(e => e.UyeAd)
                .IsUnicode(false);

            modelBuilder.Entity<Uye>()
                .Property(e => e.UyeSoyad)
                .IsUnicode(false);

            modelBuilder.Entity<UyeHatirlatma>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<UyeHatirlatma>()
                .Property(e => e.DanısanId)
                .IsUnicode(false);

            modelBuilder.Entity<UyeHatirlatma>()
                .Property(e => e.UyeHatirlatmaMesaj)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.UyeId)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.UyeIletisimTelefon)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.UyeIletisimIl)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.UyeIletisimIlce)
                .IsUnicode(false);

            modelBuilder.Entity<UyeIletisim>()
                .Property(e => e.UyeIletisimAdres)
                .IsUnicode(false);

            modelBuilder.Entity<UyeOdeme>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<UyeOdeme>()
                .Property(e => e.UyeId)
                .IsUnicode(false);

            modelBuilder.Entity<UyeOdeme>()
                .Property(e => e.UyeOdemeTutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UyeOdeme>()
                .Property(e => e.UyeOdemeAciklama)
                .IsUnicode(false);

            modelBuilder.Entity<UyeRandevu>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<UyeRandevu>()
                .Property(e => e.DanisanId)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeId)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketUnvan)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketIl)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketIlce)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketAdres)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketVergiDairesi)
                .IsUnicode(false);

            modelBuilder.Entity<UyeSirket>()
                .Property(e => e.UyeSirketVergiNo)
                .IsUnicode(false);
        }
    }
}
