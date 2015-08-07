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
            if (Util.validarCPF(cpf))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = "01";
                falha.DataErro = DateTime.Now;
                falha.Motivo = "CPF inválido.";
                throw new FaultException<PortabilidadeFault>(falha);
            }

            //[validação se o cliente existe na base de dados]
            if (cpf.Equals("88888888888"))
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
            validarCliente(customer.Cpf);

            validarConta(customer);

            Acount conta = new Acount();
            conta.Number = "88433503";
            conta.Valor = 10;
            conta.DataUltimoVencimento = new DateTime(2015, 1, 1);
            conta.Paga = false;

            return conta;
        }

        private void validarConta(Custumer customer)
        {
            //validacao se o cliente possui conta
            if (customer.Cpf.Equals("65290704191"))
            {
                PortabilidadeFault falha = new PortabilidadeFault();
                falha.CodigoErro = "04";
                falha.DataErro = DateTime.Now;
                falha.Motivo = "Cliente não possui conta.";
                throw new FaultException<PortabilidadeFault>(falha);
            }
        }


    }
}
