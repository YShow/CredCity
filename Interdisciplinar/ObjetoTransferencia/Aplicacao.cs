using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Aplicacao
    {
        public int IdAplicacao { get; set; }
        public float TaxaRendimento { get; set; }
        public DateTime Prazo { get; set; }
        public float Valor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
