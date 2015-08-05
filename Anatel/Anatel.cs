using System;
using ModeloCanonico;
namespace Anatel
{
    public class Anatel: MarshalByRefObject, IAnatel
    {
        public RetornoPortabilidade SolicitarPortabilidadeNumerica(ModeloCanonico.Custumer custumer)
        {

            RetornoPortabilidade retorno = new RetornoPortabilidade();

            retorno.Bilhete = "1234567890";
            retorno.Janela = DateTime.Now.AddHours(2).ToLongTimeString();
            retorno.CodigoErro = "0";
            retorno.DataErro = DateTime.Now;
            retorno.Motivo = "Portabilidade efetuada com sucesso.";

            //[validação se já existe um ticket aberto para essa pessoa]
            if (custumer.Cpf.Equals("04986491644"))
            {
                retorno.CodigoErro = "1";
                retorno.DataErro = DateTime.Now;
                retorno.Motivo = "Já existe um processo de portabilidade em aberto para o CPF "+custumer.Cpf;
            }

            //[validação se existe uma portabilidade não finalizada corretamente(com pendencias)]
            if (custumer.Cpf.Equals("05666561677"))
            {
                retorno.CodigoErro = "2";
                retorno.DataErro = DateTime.Now;
                retorno.Motivo = "Existe uma portabilidade (Número do bilhete: 0987654321) com pendencias para o CPF " + custumer.Cpf;
            }

            return retorno;
        }
    }
}
