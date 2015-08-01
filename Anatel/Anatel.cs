using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloCanonico;
namespace Anatel
{
    public class Anatel: MarshalByRefObject, IAnatel
    {
        public RetornoPortabilidade SolicitarPortabilidadeNumerica(ModeloCanonico.Custumer custumer)
        {

            RetornoPortabilidade retorno = new RetornoPortabilidade();

            retorno.Bilhete = "1234567890";
            retorno.CodigoErro = "0";
            retorno.DataErro = DateTime.Now;
            retorno.Motivo = "Portabilidade efetuada com sucesso.";

            if (custumer.Nome.Equals("Lucas"))
            {
                retorno.CodigoErro = "1";
                retorno.DataErro = DateTime.Now;
                retorno.Motivo = "Cliente inválido.";
            }

            return retorno;
        }
    }
}
