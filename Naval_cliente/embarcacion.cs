﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naval_cliente
{
    public class embarcacion
    {
        public string nombre { get; set; }
        public int inicio { get; set; }
        public int fin { get; set; }
        public List<int> celdas { get; set; }
        public string estado { get; set; }
    }
}
