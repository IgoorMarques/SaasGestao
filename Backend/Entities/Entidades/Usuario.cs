using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entidades
{
    public class Usuario : IdentityUser
    {
        [Column("USER_NOME")]
        public string Nome { get; set; }
    }
}
