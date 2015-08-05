using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    /**
    * Retorno portabilidade utilizado pelo webservice do projeto Anatel.
    *
    */
    [Serializable]
    public class RetornoPortabilidade
    {

        string bilhete;

        public string Bilhete
        {
            get { return bilhete; }
            set { bilhete = value; }
        }

        string janela;

        public string Janela
        {
            get { return janela; }
            set { janela = value; }
        }

        string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        DateTime dataErro;

        public DateTime DataErro
        {
            get { return dataErro; }
            set { dataErro = value; }
        }


        string codigoErro;

        public string CodigoErro
        {
            get { return codigoErro; }
            set { codigoErro = value; }
        }

    }
}
