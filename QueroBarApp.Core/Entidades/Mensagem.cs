using System;

namespace QueroBarApp.Core.Entidades
{
    public class Mensagem : EntidadeBase
    {
        public DateTime DataEnvio { get; set; }
        public string Texto { get; set; }

        #region Relacionamentos

        public int RemetenteId { get; set; }
        public Usuario Rementente { get; set; }

        public int DestinatarioId { get; set; }
        public Usuario Destinatario { get; set; }

        #endregion
    }
}
