using QueroBarApp.Core.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace QueroBarApp.Servicos
{
    public class ServicoBase<T> where T : EntidadeBase
    {
        public ServicoBase()
        {
            CriarArquivo();
        }

        public void Salvar(T entidade)
        {
            //lendo entidades no arquivo Json
            var entidades = Entidades();
            entidades.Add(entidade);

            //Serializa entidades lida no arquivo.json
            var entidadesJson = JsonSerializer.Serialize(entidades);

            //Escreve entidade nova no arquivo .json
            File.WriteAllText(CaminhoArquivo(), entidadesJson);
        }

        public IList<T> Entidades()
        {
            //Lendo entidades
            var entidadesJson = File.Exists(CaminhoArquivo()) ? File.ReadAllText(CaminhoArquivo()) : string.Empty;

            if (string.IsNullOrEmpty(entidadesJson))
                return new List<T>();

            return JsonSerializer.Deserialize<IList<T>>(entidadesJson);
        }

        private void CriarArquivo()
        {
            if (File.Exists(CaminhoArquivo()))
               return;

            var fileInfo = new FileInfo(CaminhoArquivo());
            CriarDiretorio(fileInfo.DirectoryName);

            using (File.Create(CaminhoArquivo()))
            {
            }
        }

        private void CriarDiretorio(string caminho)
        {
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
        }

        private string CaminhoArquivo()
        {
            return $"E:\\QueroBar\\Entidades\\{typeof(T).Name.ToLower()}.json";
        }
    }
}
