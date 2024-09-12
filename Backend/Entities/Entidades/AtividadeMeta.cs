using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class AtividadeMeta
    {
        [Key]
        [Column("ATIVIDADE_ID")]
        public int Id { get; set; }

        [ForeignKey("Casal")]
        [Column("CASAL_ID")]
        public int CasalId { get; set; }
        public Casal Casal { get; set; }

        [ForeignKey("MetaEspiritual")]
        [Column("META_ID")]
        public int MetaId { get; set; }
        public MetaEspiritual MetaEspiritual { get; set; }

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
