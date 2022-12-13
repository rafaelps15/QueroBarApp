using QueroBarApp.Core.Enums;
using System.Collections.Generic;

namespace QueroBarApp.Core.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public UsuarioTipoEnum TipoUsuario { get; set; }

        #region Relacionamentos

        public ICollection<Bar> Bares { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }

        public ICollection<Evento> Eventos { get; set; }

        public ICollection<Mensagem> Mensagens { get; set; }
        #endregion
    }
}
