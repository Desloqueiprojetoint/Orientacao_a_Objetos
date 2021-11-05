using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desloquei.Models
{
    public class Motorista
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cnh { get; set; }
        public DateTime ValidadeCnh { get; set; }
        public string CategoriaCnh { get; set; }
        public bool StatusCnh { get; set; }


    }
}
