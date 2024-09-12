using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Entities.Entidades
{
    public class DesafioEspiritual
    {
        [Key]
        [Column("DESAFIO_ID")]
        public int Id { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("PONTOS_RECOMPENSA")]
        public int PontosRecompensa { get; set; }

        [Column("DURACAO")]
        public string Duracao { get; set; }

        [Column("TIPO")]
        public string Tipo { get; set; }

        public ICollection<ParticipacaoDesafios> ParticipacoesDesafios { get; set; }
    }

}

