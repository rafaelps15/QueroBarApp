using QueroBarApp.Core.Entidades;
using System;

namespace QueroBarApp.Servicos.UsuarioServicos
{
    public class UsuarioServico
    {
        private readonly ServicoBase<Usuario> _servicoBase;

        public UsuarioServico()
        {
            _servicoBase = new ServicoBase<Usuario>();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            if (string.IsNullOrEmpty(usuario?.Nome))
                throw new Exception("Campo nome é obrigatório");

            _servicoBase.Salvar(usuario);
        }
    }
}
