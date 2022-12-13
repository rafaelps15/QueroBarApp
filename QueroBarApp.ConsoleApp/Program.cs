using QueroBarApp.Core.Entidades;
using QueroBarApp.Core.Enums;
using QueroBarApp.Servicos.UsuarioServicos;
using System;

namespace QueroBarApp.ConsoleApp
{
    internal class Program
    {
        private static readonly UsuarioServico _usuarioServico;

        static Program()
        {
            _usuarioServico = new UsuarioServico();
        }

        static void Main(string[] args)
        {
            var usuario = new Usuario()
            {
                Id = 2,
                Nome = "Jose",
                Email = "joseps15@hotmail.com",
                Senha = "12345678",
                TipoUsuario = UsuarioTipoEnum.Administrador
            };

            try
            {
                _usuarioServico.CadastrarUsuario(usuario);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Encerrando o sistema com o erro: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
