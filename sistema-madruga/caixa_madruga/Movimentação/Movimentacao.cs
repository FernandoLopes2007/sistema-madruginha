using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caixa_madruga.Movimentação;

namespace caixa_madruga
{
    public class Movimentacao
    {
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
    }
}

