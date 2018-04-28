using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    class Cliente
    {
        public int IdCLiente { get; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string TipoPessoa { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public string Status { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public float Renda { get; set; }
        public string registro { get; set; }
        public CartaoCredito CartaoCredito { get; set; }
    }

}
