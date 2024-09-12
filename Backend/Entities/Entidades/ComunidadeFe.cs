using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class ComunidadeFe
    {
        [Key]
        [Column("COMUNIDADE_ID")]
        public int Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("LOCALIZACAO")]
        public string Localizacao { get; set; }

        [Column("CONTATO")]
        public string Contato { get; set; }

        [Column("DENOMINACAO")]
        public string Denominacao { get; set; }

        public ICollection<ConexaoComunidadeFe> ConexoesComunidadeFe { get; set; }
    }
}
