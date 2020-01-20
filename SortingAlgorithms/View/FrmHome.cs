using SortingAlgorithms.Controller;
using SortingAlgorithms.Model.Enumeradores;
using SortingAlgorithms.Model.ViewModel;
using SortingAlgorithms.View;
using System;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Frmhome : Form
    {
        private AlgorithmSortController _algorithmSort { get; set; }
        private readonly Cronometro _cronometro;


        public Frmhome()
        {
            InitializeComponent();
            _algorithmSort = new AlgorithmSortController();
            _cronometro = new Cronometro();
        }
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {

                AtivaDesativaBotoes(false);
                CboxParaEnum();

                _cronometro.Iniciar();

                var conjuntoOrdenado = _algorithmSort.OrdenarBubbleSort(CboxParaEnum());

                TimeSpan tempoDecorrido = _cronometro.GetTempoDecorrido();
                _cronometro.Parar();

                AtivaDesativaBotoes(true);
                var frm = new FrmTempoDecorrido(tempoDecorrido, _algorithmSort.Comparacoes, _algorithmSort.Trocas);
                frm.Show();

                MostraNoRichTxtBox(conjuntoOrdenado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            try
            {
                AtivaDesativaBotoes(false);
                CboxParaEnum();

                _cronometro.Iniciar();

                var conjuntoOrdenado = _algorithmSort.OrdenarInsertionSort(CboxParaEnum());

                TimeSpan tempoDecorrido = _cronometro.GetTempoDecorrido();
                _cronometro.Parar();

                AtivaDesativaBotoes(true);
                var frm = new FrmTempoDecorrido(tempoDecorrido, _algorithmSort.Comparacoes, _algorithmSort.Trocas);
                frm.Show();

                MostraNoRichTxtBox(conjuntoOrdenado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            try
            {

                AtivaDesativaBotoes(false);
                CboxParaEnum();

                _cronometro.Iniciar();

                var conjuntoOrdenado = _algorithmSort.OrdenarQuickSort(CboxParaEnum());

                TimeSpan tempoDecorrido = _cronometro.GetTempoDecorrido();
                _cronometro.Parar();

                AtivaDesativaBotoes(true);
                var frm = new FrmTempoDecorrido(tempoDecorrido, _algorithmSort.Comparacoes, _algorithmSort.Trocas);
                frm.Show();

                MostraNoRichTxtBox(conjuntoOrdenado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            try
            {
                AtivaDesativaBotoes(false);
                CboxParaEnum();

                _cronometro.Iniciar();

                var conjuntoOrdenado = _algorithmSort.OrdenarSelectionSort(CboxParaEnum());

                TimeSpan tempoDecorrido = _cronometro.GetTempoDecorrido();
                _cronometro.Parar();

                AtivaDesativaBotoes(true);
                var frm = new FrmTempoDecorrido(tempoDecorrido, _algorithmSort.Comparacoes, _algorithmSort.Trocas);
                frm.Show();

                MostraNoRichTxtBox(conjuntoOrdenado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            try
            {
                AtivaDesativaBotoes(false);
                CboxParaEnum();

                _cronometro.Iniciar();

                var conjuntoOrdenado = _algorithmSort.OrdenarCountingSort(CboxParaEnum());

                TimeSpan tempoDecorrido = _cronometro.GetTempoDecorrido();
                _cronometro.Parar();

                AtivaDesativaBotoes(true);
                var frm = new FrmTempoDecorrido(tempoDecorrido, _algorithmSort.Comparacoes, _algorithmSort.Trocas);
                frm.Show();

                MostraNoRichTxtBox(conjuntoOrdenado);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void MostraNoRichTxtBox(int[] conjuntoDeDados)
        {
            richTxTBResultado.Clear();
            for (int i = 0; i < conjuntoDeDados.Length; i++)
            {
                richTxTBResultado.AppendText($"{conjuntoDeDados[i]} ");
                Application.DoEvents();
            }
        }

        private TiposArquivo CboxParaEnum()
        {
            string itemSelecionado = cBoxArquivo.Items[cBoxArquivo.SelectedIndex].ToString().ToLower();
            TiposArquivo convertido = (TiposArquivo)Enum.Parse(typeof(TiposArquivo), itemSelecionado);

            return convertido;
        }

        private void AtivaDesativaBotoes(bool controle)
        {
            btnBubbleSort.Enabled = controle;
            btnCountingSort.Enabled = controle;
            btnInsertionSort.Enabled = controle;
            btnQuickSort.Enabled = controle;
            btnSelectionSort.Enabled = controle;
        }
    }

}
