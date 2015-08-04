using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{

    [Serializable]
    public class Custumer
    {
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        string enderecoCompleto;

        public string EnderecoCompleto
        {
            get { return enderecoCompleto; }
            set { enderecoCompleto = value; }
        }
    }
}