using BooksGAM4.Data;
using BooksGAM4.Data.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BooksGAM4.Services
{
    public class LivroServices
    {
        /// <summary>
        /// Este é o serviço responsável por realizar o upload do arquivo, sua validação é feita em duas partes, uma aqui com a 
        /// checagem da existência do arquivo a outra de validação da chamada é no form que o invocar.
        /// Ao realizar o upload este serviço muda o nome do arquivo, dando como retorno uma string com o camnho do arquivo já com o nome setado.
        /// </summary>
        /// <param name="arquivos"></param>
        /// <param name="context"></param>
        /// <param name="_appEnvironment"></param>
        /// <returns></returns>
        public static async Task<string> EnviarArquivo(List<IFormFile> arquivos, ApplicationDbContext context, IHostingEnvironment _appEnvironment)
        {
            long tamanhoArquivos = arquivos.Sum(f => f.Length);
            
            var caminhoArquivo = Path.GetTempFileName();            
            
            string nomeArquivo = "";

            foreach (var arquivo in arquivos)
            {
                //verifica se existe arquivo
                if (arquivo == null || arquivo.Length == 0)
                {
                    return "false";
                }

                string pasta = "livrosImg";

                // Define um nome para o arquivo combinado do toal de registros da tabela livro e de milesegundos
                var interaNome = LivroDAL.ListaLivro(context).Count().ToString();
                nomeArquivo = "CapaDoLivro_" + interaNome + DateTime.Now.Millisecond.ToString();

                //verifica qual o tipo de arquivo : jpg, gif, png
                if (arquivo.FileName.Contains(".jpg"))
                    nomeArquivo += ".jpg";
                else if (arquivo.FileName.Contains(".gif"))
                    nomeArquivo += ".gif";
                else if (arquivo.FileName.Contains(".png"))
                    nomeArquivo += ".png";
                else
                    //nomeArquivo += ".tmp";
                    return "";
                
                string caminho_WebRoot = _appEnvironment.WebRootPath;
                
                string caminhoDestinoArquivo = caminho_WebRoot + "\\images\\" + pasta + "\\";
                
                string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + "\\recebidos\\" + nomeArquivo;

                //copia o arquivo para o local de destino original
                using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                {
                    await arquivo.CopyToAsync(stream);
                }

                nomeArquivo = "/images/livrosImg/recebidos/" + nomeArquivo;
            }

            return nomeArquivo;
        }

    }
}
