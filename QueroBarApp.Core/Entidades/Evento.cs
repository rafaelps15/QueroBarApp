using System;
using System.Collections.Generic;

namespace QueroBarApp.Core.Entidades
{
    public class Evento : EntidadeBase
    { 
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public byte[] Imagem { get; set; }

        public ICollection<Ingresso> Ingressos { get; set; }

        #region Relacionamentos

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        #endregion
    }
}
