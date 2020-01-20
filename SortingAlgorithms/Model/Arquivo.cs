using System.IO;
using SortingAlgorithms.Model.Enumeradores;

namespace SortingAlgorithms.Model
{
    public class Arquivo
    {
        private static readonly string[] pathArquivos = new string[12]{
            "100k.txt", "100k-ordenado-reverso.txt", "100k-ordernado.txt",
            "1kk.txt" , "1kk-ordenado.txt"         , "1kk-ordenado-reverso.txt",
            "5kk.txt" , "5kk-ordenado.txt"         , "5kk-ordenado-reverso.txt",
            "10kk.txt", "10kk-ordenado.txt"        , "10kk-ordenado-reverso.txt" };

        public static int[] LerEConverter(TiposArquivo arquivoEscolhido)
        {
            int indexArquivo = (int)arquivoEscolhido;
            string arquivoString = @"Dados\" +
                pathArquivos[indexArquivo];

            // Leitura do arquivo
            var arquivo = File.ReadAllLines(arquivoString);
            int[] arrayDeInt = new int[arquivo.Length];

            for (int i = 0; i < arrayDeInt.Length; i++)
            {
                // Conversão
                arrayDeInt[i] = int.Parse(arquivo[i]);
            }

            return arrayDeInt;
        }        
    }
}


