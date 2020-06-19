namespace MinhoShine.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recomendacao")]
    public partial class Recomendacao
    {
        [Key]
        public int IdRecomendacao { get; set; }

        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Mensagem { get; set; }

        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
