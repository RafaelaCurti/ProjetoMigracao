using System;
using System.Net;

namespace ProjetoMigracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //    using (var client = new WebClient())
            //    {
            //        client.DownloadFile("https://drive.google.com/file/d/11JEE8WKSD9_FBAfGfiFq_z-ZtS1bmGeR/view", "cnpj.zip");
            //    }

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("https://drive.google.com/file/d/11JEE8WKSD9_FBAfGfiFq_z-ZtS1bmGeR/view"),
                    // Param2 = Path to save
                    "D:\\Dowload\\cnpj.zip"
                );
            }

            // Event to track the progress
            void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
            {
                progressBar.Value = e.ProgressPercentage;
            }
            Console.ReadKey();





            //Entrar no site da receita 
            //var receitaFederal = new System.Net.WebClient().DownloadString("");
            //Console.WriteLine(new System.Net.WebClient().DownloadString("https://receita.economia.gov.br/orientacao/tributaria/cadastros/cadastro-nacional-de-pessoas-juridicas-cnpj/dados-publicos-cnpj"));
            //Console.ReadKey();
            //Baixar os (7) CNPJs

            //Extrair os arquivos 

            // Ler o arquivo

        }
}
}
