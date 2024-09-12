using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    public class ReflexaoDiaria
    {
        [Key]
        [Column("REFLEXAO_ID")]
        public int Id { get; set; }

        [Column("DATA")]
        public DateTime Data { get; set; }

        [Column("VERSICULO")]
        public string Versiculo { get; set; }

        [Column("MENSAGEM_INSPIRADORA")]
        public string MensagemInspiradora { get; set; }

        [Column("SUGESTAO_DISCUSSAO")]
        public string SugestaoDiscussao { get; set; }
    }
}
