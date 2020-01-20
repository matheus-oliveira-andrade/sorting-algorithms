using System;
using System.Diagnostics;

namespace SortingAlgorithms.Model.ViewModel
{
    class Cronometro
    {
        private readonly Stopwatch _cronometro;

        public Cronometro()
        {
            this._cronometro = new Stopwatch();
        }
        public void Iniciar()
        {
            _cronometro.Start();
        }
        public void Parar()
        {
            _cronometro.Stop();
            recomeçar();
        }
        private void recomeçar()
        {
            _cronometro.Reset();
        }
        public TimeSpan GetTempoDecorrido()
        {
            return _cronometro.Elapsed;
        }

    }
}
