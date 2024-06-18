using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.config
{
    public class ContextBase : IdentityDbContext<Usuario>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
            }
        }

        private string ObterStringConexao()
        {
            return "Data Source=DESKTOP-4LE6SQB;Initial Catalog=DBSistemaWpp;Integrated Security=True;User ID=sa;Password=12345;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False; Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
    }
}
