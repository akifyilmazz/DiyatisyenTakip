namespace Diesta.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uye")]
    public partial class Uye
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsActive { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsDeleted { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string UyeUnvan { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string UyeMail { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string UyeAd { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string UyeSoyad { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UyeDogumTarih { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool UyeCinsiyet { get; set; }
    }
}
