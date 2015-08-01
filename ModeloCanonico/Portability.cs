using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    [Serializable]
    public class Portability
    {
        string bilhete;

        public string Bilhete
        {
            get { return bilhete; }
            set { bilhete = value; }
        }
    }
}
