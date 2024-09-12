using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entidades
{
    public class Usuario : IdentityUser
    {
        [Column("USER_NOME")]
        public string Nome { get; set; }

        [Column("NIVEL_FE")]
        public string NivelFe { get; set; } // Ex: "Crente", "Novo na Fé", "Não Convertido"

        [Column("PONTUACAO_ATUAL")]
        public int PontuacaoAtual { get; set; } = 0;

        [Column("STATUS_CONEXAO_ESPIRITUAL")]
        public string StatusConexaoEspiritual { get; set; } // Ex: "Conectado", "Desconectado"

        [Column("USER_DATA_NASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Column("USER_DATA_REGISTRO")]
        public DateTime DataRegistro { get; set; } = DateTime.Now;

        // Navegação Relacionamentos
        public ICollection<Casal> CasalComoParceiro1 { get; set; } // Usuário como parceiro 1 em casais
        public ICollection<Casal> CasalComoParceiro2 { get; set; } // Usuário como parceiro 2 em casais
    }
}
