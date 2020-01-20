using System;
using SortingAlgorithms.Model;
using SortingAlgorithms.Model.Enumeradores;

namespace SortingAlgorithms.Controller
{
    public class AlgorithmSortController
    {
        public long Comparacoes { get; private set; }
        public long Trocas { get; private set; }

        public int[] OrdenarBubbleSort(TiposArquivo arquivoEscolhido)
        {
            BubbleSort bubbleSort = new BubbleSort();
            var conjuntoDeDados = Arquivo.LerEConverter(arquivoEscolhido);

            var conjuntoOrdenado = bubbleSort.Ordenar(conjuntoDeDados);
            Comparacoes = bubbleSort.Comparacoes;
            Trocas = bubbleSort.Trocas;

            return conjuntoOrdenado;
        }
        public int[] OrdenarCountingSort(TiposArquivo tiposArquivo)
        {
            CountingSort countingSort = new CountingSort();
            var conjuntoDeDados = Arquivo.LerEConverter(tiposArquivo);

            var conjuntoOrdenado = countingSort.Ordenar(conjuntoDeDados);
            Comparacoes = countingSort.Comparacoes;
            Trocas = countingSort.Trocas;

            return conjuntoOrdenado;
        }
        public int[] OrdenarSelectionSort(TiposArquivo tiposArquivo)
        {
            SelectionSort selectionSort = new SelectionSort();
            var conjuntoDeDados = Arquivo.LerEConverter(tiposArquivo);

            var conjuntoOrdenado = selectionSort.Ordenar(conjuntoDeDados);

            Comparacoes = selectionSort.Comparacoes;
            Trocas = selectionSort.Trocas;

            return conjuntoOrdenado;
        }
        public int[] OrdenarInsertionSort(TiposArquivo tiposArquivo)
        {
            InsertionSort insertionSort = new InsertionSort();
            var conjuntoDeDados = Arquivo.LerEConverter(tiposArquivo);

            var conjuntoOrdenado = insertionSort.Ordenar(conjuntoDeDados);

            Comparacoes = insertionSort.Comparacoes;
            Trocas = insertionSort.Trocas;

            return conjuntoOrdenado;
        }
        public int[] OrdenarQuickSort(TiposArquivo tiposArquivo)
        {
            QuickSort quickSort = new QuickSort();
            var conjuntoDeDados = Arquivo.LerEConverter(tiposArquivo);

            var conjuntoOrdenado = quickSort.Ordenar(conjuntoDeDados);

            Comparacoes = quickSort.Comparacoes;
            Trocas = quickSort.Trocas;

            return conjuntoOrdenado;
        }
    }
}
