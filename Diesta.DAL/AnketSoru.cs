namespace Diesta.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnketSoru")]
    public partial class AnketSoru
    {
        [StringLength(255)]
        public string Id { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string AnketTurId { get; set; }

        [Column("AnketSoru", TypeName = "text")]
        [Required]
        public string AnketSoru1 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnketSoruCevap { get; set; }
    }
}
