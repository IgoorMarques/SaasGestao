using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{

    [Table("Academia")]
    public class NomeModulo
    {
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
