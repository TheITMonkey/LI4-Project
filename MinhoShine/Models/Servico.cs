namespace MinhoShine.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servico")]
    public partial class Servico
    {
        [Key]
        public int IdServico { get; set; }

        [Required]
        [StringLength(80)]
        public string Morada { get; set; }

        public float Duracao { get; set; }

        public float Preco { get; set; }

        [Required]
        [StringLength(255)]
        public string Descricao { get; set; }

        public int Dia { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public int Hora { get; set; }

        public int Minutos { get; set; }

        public int Limpeza { get; set; }

        public int Colchoes { get; set; }

        public int Lavandaria { get; set; }

        public int Engomaria { get; set; }

        public int IdCliente { get; set; }

        public int IdFuncionario { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Funcionario Funcionario { get; set; }
    }
}
