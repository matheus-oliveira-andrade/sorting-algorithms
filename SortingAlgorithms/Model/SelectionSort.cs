namespace SortingAlgorithms.Model
{
    public class SelectionSort : ISort
    {
        public long Trocas { get; private set; }
        public long Comparacoes { get; private set; }

        public int[] Ordenar(int[] conjuntoDeDados)
        {
            //assim como no bubble sort, serao necessarios dois loops 
            // um para cada elemento da lista e outro
            // para cada um desses elementos percorrer toda a lista

            int min, temp;

            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                min = i; //considera o valor de indice mais baixo

                for (int j = 0; j < conjuntoDeDados.Length; j++)
                {
                    Comparacoes++;
                    if (conjuntoDeDados[j] > conjuntoDeDados[min])
                    {
                        min = j;

                        //Aqui ocorre a troca de posicao dos itens
                        //troca o menor elemento encontrado com o item que este sendo iterado
                        Trocas++;
                        temp = conjuntoDeDados[min];
                        conjuntoDeDados[min] = conjuntoDeDados[i];
                        conjuntoDeDados[i] = temp;
                    }

                }

            }
            return conjuntoDeDados;
        }
    }
}
