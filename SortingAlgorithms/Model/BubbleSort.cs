using System.Windows.Forms;

namespace SortingAlgorithms.Model
{
    public class BubbleSort : ISort
    {
        public long Comparacoes { get; private set; }
        public long Trocas { get; private set; }

        public int[] Ordenar(int[] conjuntoDeDados)
        {
            var _dados = conjuntoDeDados;

            for (int i = 0; i < _dados.Length; i++)
            {
                for (int j = 0; j < _dados.Length; j++)
                {
                    if (j + 1 >= _dados.Length)
                    {
                        break;
                    }
                        // comparação
                        Comparacoes++;
                    if (_dados[j] > _dados[j + 1])
                    {
                        int copiaPosicao = _dados[j];

                        _dados[j] = _dados[j + 1];
                        // Troca
                        Trocas++;
                        _dados[j + 1] = copiaPosicao;
                    }
                }
                Application.DoEvents();
            }
            return _dados;
        }
    }
}