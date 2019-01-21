using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neurosigmoid
{
    class NeuralNetwork
    {
        public double LearningRate { get; set; }
        public List<Layer> Layers { get; set; }
        public int LayerCount { get { return Layers.Count; } }

        public NeuralNetwork(double learningRate, int[] layers)
        {
            if (layers.Length < 2) return;

            this.LearningRate = learningRate;
            this.Layers = new List<Layer>();

            for (int l = 0; l < layers.Length; l++)
            {
                Layer layer = new Layer(layers[l]);
                this.Layers.Add(layer);

                for (int n = 0; n < layers[l]; n++)
                    layer.Neurons.Add(new Neuron());

                layer.Neurons.ForEach((nn) =>
                {
                    if (l == 0)
                        nn.Bias = 0;
                    else
                        for (int d = 0; d < layers[l - 1]; d++)
                            nn.Dendrites.Add(new Dendrite());
                });
            }
        }
    }
}
