using System;
using System.Windows.Forms;

namespace SortingAlgorithms.View
{
    public partial class FrmTempoDecorrido : Form
    {
        private long _trocas;
        private long _comparacoes;
        private TimeSpan _tempoDecorrido;

        public FrmTempoDecorrido(TimeSpan tempoDecorrido, long comparacoes, long trocas)
        {
            InitializeComponent();

            _comparacoes = comparacoes;
            _trocas = trocas;
            _tempoDecorrido = tempoDecorrido;
            SetLabels();
        }
        private void SetLabels()
        {
            lblTempo.Text = $"{_tempoDecorrido.Hours}:{_tempoDecorrido.Minutes}:{_tempoDecorrido.Seconds}:{_tempoDecorrido.Milliseconds}";
            lblNTrocas.Text = _trocas.ToString();
            lblNComparacoes.Text = _comparacoes.ToString();
        }
    }
}
