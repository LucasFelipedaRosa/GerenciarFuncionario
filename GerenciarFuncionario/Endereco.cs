using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionario
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        public string Rua { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        public string Numero { get; set; }
        [Required]
        public Cidade Cidade { get; set; }
    }
}
