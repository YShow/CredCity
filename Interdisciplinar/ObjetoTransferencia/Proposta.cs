using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Proposta
    {
        public int IdProposta { get; set; }
        public decimal ValorParcela { get; set; }
        public bool StatusParcela { get; set; }
        public decimal ValorTotalProposta { get; set; }
        public Credito Credito { get; set; }
        public Cliente Cliente { get; set; }
    }
}
