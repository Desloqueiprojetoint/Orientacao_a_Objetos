using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desloquei.Models
{
    public class Veiculo
    {
        public long Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Renavam { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public int Ano { get; set; }
        public int QdtAssentos { get; set; }
        public string CategoriaVeiculo { get; set; }
        public bool Status { get; set; }




    }
}
