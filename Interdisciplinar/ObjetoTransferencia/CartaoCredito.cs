using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class CartaoCredito
    {
        public int IdCartao { get; }
        public float Limite { get; set; }
        public Cliente Cliente { get; set; }
    }
}
