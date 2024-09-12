using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Entities.Entidades
{
    public class MetaEspiritual
    {
        [Key]
        [Column("META_ID")]
        public int Id { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("PONTOS_RECOMPENSA")]
        public int PontosRecompensa { get; set; }

        [Column("PONTOS_PENALIDADE")]
        public int PontosPenalidade { get; set; }

        [Column("FREQUENCIA")]
        public string Frequencia { get; set; }

        [Column("TIPO")]
        public string Tipo { get; set; }

        [Column("NIVEL_DIFICULDADE")]
        public string NivelDificuldade { get; set; }

        public ICollection<AtividadeMeta> AtividadesMetas { get; set; }
    }

}

