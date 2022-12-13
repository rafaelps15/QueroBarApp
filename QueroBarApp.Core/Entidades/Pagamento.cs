using System;

namespace QueroBarApp.Core.Entidades
{
    public class Pagamento : EntidadeBase
    {
        public DateTime DataPagamento { get; set; }

        public Ingresso Ingresso { get; set; }

        public int IngressoId { get; set; }
    }
}
