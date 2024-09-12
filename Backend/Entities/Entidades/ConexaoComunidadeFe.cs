using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class ConexaoComunidadeFe
    {
        [Key]
        [Column("CONEXAO_ID")]
        public int Id { get; set; }

        [ForeignKey("Casal")]
        [Column("CASAL_ID")]
        public int CasalId { get; set; }
        public Casal Casal { get; set; }

        [ForeignKey("ComunidadeFe")]
        [Column("COMUNIDADE_ID")]
        public int ComunidadeId { get; set; }
        public ComunidadeFe ComunidadeFe { get; set; }

        [Column("DATA_INICIO")]
        public DateTime DataInicio { get; set; }

        [Column("STATUS")]
        public string Status { get; set; }
    }
}
