using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class Casal
    {
        [Key]
        [Column("CASAL_ID")]
        public int Id { get; set; }

        [ForeignKey("Usuario1")]
        [Column("USER_PARCEIRO1_ID")]
        public string UserParceiro1Id { get; set; }
        public Usuario Usuario1 { get; set; }

        [ForeignKey("Usuario2")]
        [Column("USER_PARCEIRO2_ID")]
        public string UserParceiro2Id { get; set; }
        public Usuario Usuario2 { get; set; }

        [Column("DATA_INICIO_RELACIONAMENTO")]
        public DateTime DataInicioRelacionamento { get; set; }

        [ForeignKey("MetaEspiritualAtual")]
        [Column("META_ESPIRITUAL_ATUAL")]
        public int? MetaEspiritualAtualId { get; set; }
        public MetaEspiritual MetaEspiritualAtual { get; set; }

        [Column("PONTUACAO_CASAL")]
        public int PontuacaoCasal { get; set; }

        [Column("STATUS_RELACIONAMENTO_ESPIRITUAL")]
        public string StatusRelacionamentoEspiritual { get; set; }

        public ICollection<AtividadeMeta> AtividadesMetas { get; set; }
        public ICollection<ParticipacaoDesafios> ParticipacoesDesafios { get; set; }
        public ICollection<ConexaoComunidadeFe> ConexoesComunidadeFe { get; set; }
    }

}
