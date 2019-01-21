using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neurosigmoid
{
    class Neuron
    {
        public double Delta { get; set; }
        public double Value { get; set; }
        public double Bias { get; set; }
        public List<Dendrite> Dendrites { get; set; }

        public int DendrideCount { get { return Dendrites.Count; } }

        public Neuron()
        {
            Random r = new Random(Environment.TickCount);
            this.Bias = r.NextDouble();
            this.Dendrites = new List<Dendrite>();
        }
    }

}
