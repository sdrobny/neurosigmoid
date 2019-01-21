using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neurosigmoid
{
    class Layer
    {
        public List<Neuron> Neurons { get; set; }
        public int NeuronCount { get { return Neurons.Count; } }

        public Layer(int numberNeurons)
        {
            Neurons = new List<Neuron>(numberNeurons);
        }
    }
}
