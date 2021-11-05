using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desloquei.Models
{
    public class Solicitacao
    {
        public long Id { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
        public string Trajeto { get; set; }
        public double Valor { get; set; }
    }
}
