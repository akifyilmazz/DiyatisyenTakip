namespace Diesta.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UyeHatirlatma")]
    public partial class UyeHatirlatma
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
        public string DanısanId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime UyeHatirlatmaTarih { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string UyeHatirlatmaMesaj { get; set; }
    }
}
