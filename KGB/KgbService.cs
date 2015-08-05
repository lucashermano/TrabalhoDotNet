using ModeloCanonico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KGB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class KgbService : IKgbService
    {
        public Custumer ObterStatusFinanceiroCliente(string cpf)
        {
            //• Operação que retorna o status financeiro do cliente a partir de um dado CPF de
            //entrada.
            //• Validar se o dado é válido
            //• CPF obrigatório
            //• Usar WCF

            validarCliente(cpf);

            Custumer customer = GetCustomerByCPF(cpf);

            return customer;
        }

        private void validarCliente(string cpf)
        {
            //[validação de digito verificador do cpf]
            if (validarCPF(cpf))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = "01";
                falha.DataErro = DateTime.Now;
                falha.Motivo = "CPF inválido.";
                throw new FaultException<PortabilidadeFault>(falha);
            }

            //[validação se o cliente existe na base de dados]
            if (cpf.Equals("04986491644"))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = "02";
                falha.DataErro = DateTime.Now;
                falha.Motivo = "Cliente inexistente na base de dados.";
                throw new FaultException<PortabilidadeFault>(falha);
            }

            //[validação se possui divida em aberto]
            if (cpf.Equals("22785426649"))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = "03";
                falha.DataErro = DateTime.Now;
                falha.Motivo = "Cliente possui pendências com o financeiro.";
                throw new FaultException<PortabilidadeFault>(falha);
            }


        }

        public Custumer GetCustomerByCPF(string cpf)
        {
            //• Operação que retorna o cliente a partir de um dado CPF de entrada.
            //• Validar se o dado é válido
            //• CPF obrigatório
            //• Usar ASMX
            validarCliente(cpf);
            Custumer custumer = new Custumer();
            custumer.Nome = "Lucas - "+ cpf;
            return custumer;
        }

        public Acount ObterDadosConta(Custumer customer)
        {
            //• Operação que retorna a conta de um cliente
            //• Validar se o dado é válido
            //• Customer obrigatório
            //• Usar WCF
            throw new NotImplementedException();
        }

        public bool validarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }
    }
}
