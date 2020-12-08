namespace Diesta.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UyeSirket")]
    public partial class UyeSirket
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
        public string UyeId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string UyeSirketUnvan { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(150)]
        public string UyeSirketIl { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(150)]
        public string UyeSirketIlce { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(150)]
        public string UyeSirketAdres { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(200)]
        public string UyeSirketVergiDairesi { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(11)]
        public string UyeSirketVergiNo { get; set; }
    }
}
