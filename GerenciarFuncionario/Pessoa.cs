]using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionario
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required]
        public  string CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
