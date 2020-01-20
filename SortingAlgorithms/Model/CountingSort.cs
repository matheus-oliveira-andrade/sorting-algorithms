namespace SortingAlgorithms.Model
{
    public class CountingSort : ISort
    {
        public long Trocas { get; private set; }
        public long Comparacoes { get; private set; }

        public int[] Ordenar(int[] conjuntoDeDados)
        {
            int menor = 0, maior = 0;

            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                if (conjuntoDeDados[i] > maior)
                {
                    maior = conjuntoDeDados[i];
                }
                if (conjuntoDeDados[i] < menor)
                {
                    menor = conjuntoDeDados[i];
                }

                Comparacoes++;
            }

            int[] auxiliar = new int[maior - menor + 1];
            int[] saida = new int[conjuntoDeDados.Length];

            //Percorre setando o array auxiliar como 0 em todas as posições
            for (int i = 0; i < auxiliar.Length; i++)
            {
                auxiliar[i] = 0;
            }

            // Contagem dos elementos do array
            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                auxiliar[conjuntoDeDados[i] - menor] += 1;
            }

            // Soma da quantidade de elementos
            for (int i = 1; i < auxiliar.Length; i++)
            {
                auxiliar[i] += auxiliar[i - 1];
            }

            //Ordena o array
            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                int valorAux = auxiliar[conjuntoDeDados[i]]--;

                saida[valorAux - 1] = conjuntoDeDados[i];

                Trocas++;
            }

            return saida;
        }
    }
}
