﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionario
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IList<Cargo> Cargos { get; set; }
    }
}
