using System.Windows.Forms;

namespace SortingAlgorithms.Model
{
    public class InsertionSort : ISort
    {
        public long Trocas { get; private set; }
        public long Comparacoes { get; private set; }

        /// <summary>
        /// Realiza a ordenação do conjunto atravéz do método de ordenação Insertion Sort
        /// </summary>
        /// <param name="conjuntoDeDados">Conjunto de dados a ser ordenado</param>
        /// <returns>Conjunto de dados ordenados</returns>
        public int[] Ordenar(int[] conjuntoDeDados)
        {
            int x = 0, j = 0;

            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                x = conjuntoDeDados[i];
                j = i - 1;
                Comparacoes++;
                while (j >= 0 && conjuntoDeDados[j] > x)
                {
                    Trocas++;
                    conjuntoDeDados[j + 1] = conjuntoDeDados[j];
                    j--;
                }
                conjuntoDeDados[j + 1] = x;

            }

            return conjuntoDeDados;
        }

    }
}
