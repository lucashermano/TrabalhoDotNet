﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    [Serializable]
    public class Acount
    {
        string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
