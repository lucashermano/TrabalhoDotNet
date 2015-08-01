using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloCanonico;
namespace Anatel
{
    public interface IAnatel
    {
        RetornoPortabilidade SolicitarPortabilidadeNumerica(Custumer custumer); 
    }
}
