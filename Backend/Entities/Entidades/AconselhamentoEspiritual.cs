using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Entities.Entidades
{
    public class AconselhamentoEspiritual
    {
        [Key]
        [Column("ACONSELHAMENTO_ID")]
        public int Id { get; set; }

        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("CONTEUDO")]
        public string Conteudo { get; set; }

        [Column("CATEGORIA")]
        public string Categoria { get; set; }
    }
}