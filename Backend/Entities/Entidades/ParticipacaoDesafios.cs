using Entities.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Entities.Entidades
{
    public class ParticipacaoDesafios
    {
        [Key]
        [Column("PARTICIPACAO_ID")]
        public int Id { get; set; }

        [ForeignKey("Casal")]
        [Column("CASAL_ID")]
        public int CasalId { get; set; }
        public Casal Casal { get; set; }

        [ForeignKey("DesafioEspiritual")]
        [Column("DESAFIO_ID")]
        public int DesafioId { get; set; }
        public DesafioEspiritual DesafioEspiritual { get; set; }

        [Column("DATA_INICIO")]
        public DateTime DataInicio { get; set; }

        [Column("DATA_CONCLUSAO")]
        public DateTime? DataConclusao { get; set; }

        [Column("STATUS")]
        public string Status { get; set; }

        [Column("PONTUACAO_GANHA")]
        public int PontuacaoGanha { get; set; }
    }
}
