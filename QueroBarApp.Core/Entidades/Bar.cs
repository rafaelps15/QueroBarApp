namespace QueroBarApp.Core.Entidades
{
    public class Bar : EntidadeBase
    {
        public string Nome { get; set; }

        #region Relacionamentos

        public Usuario Dono { get; set; }

        public int DonoId { get; set; }

        #endregion
    }
}
