using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neurosigmoid
{
    class Neuron
    {
        //Wartosci do rekalibracji przy uczeniu (roznica?)
        public double Delta { get; set; }
        //Wartosci do rekalibracji przy uczeniu (blad?)
        public double Bias { get; set; }
        //Wartosc
        public double Value { get; set; }
        //Dendryty
        public List<Dendrite> Dendrites { get; set; }
        //Liczba dendrytów
        public int DendrideCount { get { return Dendrites.Count; } }

        public Neuron()
        {
            Random r = new Random(Environment.TickCount);
            this.Bias = r.NextDouble();
            this.Dendrites = new List<Dendrite>();
        }
    }

}
