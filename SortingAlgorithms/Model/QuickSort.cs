using System;
using System.Windows.Forms;

namespace SortingAlgorithms.Model
{
    public class QuickSort : ISort
    {
        public long Trocas { get; private set; }
        public long Comparacoes { get; private set; }

        public int[] Ordenar(int[] conjuntoDeDados)
        {
           QuickSort_Recursive(conjuntoDeDados, 0, conjuntoDeDados.Length-1);
            return conjuntoDeDados;
        }
        public void QuickSort_Recursive(int[] arr, int first, int last)
        {

            int down, high, middle, pivot, repository;
            down = first;
            high = last;
            middle = (int)((down + high) / 2);

            pivot = arr[middle];

            while (down <= high)
            {
                while (arr[down] < pivot)
                    down++;
                while (arr[high] > pivot)
                    high--;
                if (down < high)
                {
                    Trocas++;
                    repository = arr[down];
                    arr[down++] = arr[high];
                    arr[high--] = repository;
                }
                else
                {
                    if (down == high)
                    {
                        down++;
                        high--;
                    }
                }
            }
            Comparacoes++;
            if (high > first)
                QuickSort_Recursive(arr, first, high);
            Comparacoes++;
            if (down < last)
                QuickSort_Recursive(arr, down, last);
        }        
    }
}