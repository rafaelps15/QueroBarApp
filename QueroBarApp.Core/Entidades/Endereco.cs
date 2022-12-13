namespace QueroBarApp.Core.Entidades
{
    public class Endereco : EntidadeBase
    {
        public string Rua { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        #region Relacionamentos

        public Usuario Usuario { get; set; }

        public int UsuarioId { get; set; }

        #endregion
    }
}
