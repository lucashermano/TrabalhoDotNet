using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ModeloCanonico
{
    /**
    * Utilizada pelo projeto APT como contrato de falha, repassando assim para o projeto INOVIX os erros que aconteceram durante sua execução.
    *
    */
    [Serializable]
    [DataContract(Namespace = "http://br.pucminas")]
    public class PortabilidadeFault
    {
        string motivo;

        [DataMember]
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        DateTime dataErro;

        [DataMember]
        public DateTime DataErro
        {
            get { return dataErro; }
            set { dataErro = value; }
        }


        string codigoErro;

        [DataMember]
        public string CodigoErro
        {
            get { return codigoErro; }
            set { codigoErro = value; }
        }

    }
}
