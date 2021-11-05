using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desloquei.Models
{
    public class Pagamento
    {
        public long Id { get; set; }
        public double Valor { get; set; }
        public string FormaPagamento { get; set; }
    }
}
