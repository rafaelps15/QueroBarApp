namespace QueroBarApp.Core.Entidades
{
    public class Ingresso : EntidadeBase
    {
        public double Valor { get; set; }

        #region Relacionamentos

        public Evento Evento { get; set; }

        public int EventoId { get; set; }

        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }

        public Pagamento Pagamento { get; set; }

        public int PagamentoId { get; set; }

        #endregion
    }
}
