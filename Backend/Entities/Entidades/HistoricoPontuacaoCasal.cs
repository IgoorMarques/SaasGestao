using Entities.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Entities.Entidades
{
    public class HistoricoPontuacaoCasal
    {
        [Key]
        [Column("HISTORICO_ID")]
        public int Id { get; set; }

        [ForeignKey("Casal")]
        [Column("CASAL_ID")]
        public int CasalId { get; set; }
        public Casal Casal { get; set; }

        [Column("DATA_ALTERACAO")]
        public DateTime DataAlteracao { get; set; }

        [Column("MUDANCA_PONTUACAO")]
        public int MudancaPontuacao { get; set; }

        [Column("RAZAO")]
        public string Razao { get; set; }
    }

}
