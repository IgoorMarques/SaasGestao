using dominio.Interfaces;
using Entities.Entidades;
using Infra.repository.generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.repository
{
    public class RepositorioNomeModulo : RepositorioGeneric<NomeModulo>, InterfaceNomeModulo
    {

    }
}
