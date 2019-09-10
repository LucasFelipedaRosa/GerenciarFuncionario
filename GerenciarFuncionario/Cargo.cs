using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionario
{
    public class Cargo
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Atribuicao { get; set; }

        public decimal SalarioBase { get; set; }

        public IList<Departamento> Departamentos { get; set; }
    }
}
