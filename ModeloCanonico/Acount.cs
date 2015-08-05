using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    [Serializable]
    public class Acount
    {
        //numero do telefone
        string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        //valor da ultima conta
        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        //indica a data do vencimento da ultima conta
        DateTime dataUltimoVencimento;

        public DateTime DataUltimoVencimento
        {
            get { return dataUltimoVencimento; }
            set { dataUltimoVencimento = value; }
        }

        //indica se a conta está paga
        Boolean paga;

        public Boolean Paga
        {
            get { return paga; }
            set { paga = value; }
        }
    }
}
