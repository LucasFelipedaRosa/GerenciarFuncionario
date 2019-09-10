﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionario
{
    public class Funcionario : Pessoa
    {
        public IList<Lotacao> Lotacaos { get; set; }

        [Required]
        public DateTime Adimissao { get; set; }

        public DateTime demissao { get; set; }
    }
}
