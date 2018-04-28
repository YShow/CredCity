using System;


namespace ObjetoTransferencia
{
    public class Previdencia
    {
        public int IdPrevidencia { get; set; }
        public bool CoberturaRiscoMorte { get; set; }
        public decimal ContribuicaoTotal { get; set; }
        public bool CoberturaRiscoInvalidez { get; set; }
        public decimal Contribuicao { get; set;  }
        public Cliente Cliente { get; set; }
    }
}
