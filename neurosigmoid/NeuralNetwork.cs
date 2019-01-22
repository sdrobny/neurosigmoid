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

        /*
         * Funkcja Sigmoidalna
         */
        private double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }


        /*
         * Jest to funkcja, która pozwoli przetworzyć dane wejsciowe, wczytac je do sieci, oraz wypluc jej wyniki.
         * 1. Sprawdza czy ilosc danych wejsciowych = ilosc neuronow 1 warstwy
         * 2. Dla pierwszej warstwy przypisujemy neuronom wartosci wejsc
         * 3. Dla pozostalych warstw petla przez wszystkie neurony poprzedniej warstwy liczaca: ( WagaAktualnegoNeuronu + NeuronPoprzedniejWarstwy ) / WagaDendrytu 
         * 4. Przepuszcza ta wartosc przez funkcje Sigmoidalna
         * 5. Zwaraca wyniki jako tablice wartosci ostatniej warstwy
         */
        public double[] Run(List<double> input)
        {
            //Sprawdzanie poprawnosci liczby wejsc a neuronow warstwy 0
            if (input.Count != this.Layers[0].NeuronCount) return null;

            //Przejscie przez warstwy
            for (int l = 0; l < Layers.Count; l++)
            {
                Layer layer = Layers[l];

                //Przejscie przez wszystkie neurony warstwy
                for (int n = 0; n < layer.Neurons.Count; n++)
                {

                    Neuron neuron = layer.Neurons[n];
                    //Pierwsza  warstwa, czyli przypisujemy odpowiedni input;
                    if (l == 0)
                    {
                        neuron.Value = input[n];
                    } 
                    //Dla pozostalych warstw
                    else
                    {
                        neuron.Value = 0;
                        //Petla przez neurony poprzedniej warstwy
                        for (int previousLayerIndex = 0; previousLayerIndex < this.Layers[l-1].Neurons.Count; previousLayerIndex++)
                        {
                            //Wyliczenia
                            neuron.Value = (neuron.Value + this.Layers[l - 1].Neurons[previousLayerIndex].Value) * neuron.Dendrites[previousLayerIndex].Weight;
                            //Funkcja Sigmoidalna
                            neuron.Value = Sigmoid(neuron.Value + neuron.Bias);

                        }

                    }

                }


            }

            //Ostatnia warstwa jako wyjscie
            Layer last = this.Layers[this.Layers.Count - 1];
            double[] output = new double[last.Neurons.Count];
            for (int i = 0; i < last.Neurons.Count; i++) output[i] = last.Neurons[i].Value;

            return output;
        }

        

        /*
         * Uczenie sieci, poprzez porownywanie z danymi wejsciowymi (nauczycielem)
        */
        public bool Train(List<double> input, List<double> output)
        {
            //Jesli liczba danych wejscia nie jest rowna ilosci neuronow warstwy 0,
            //lub liczba danych wyjscia nie jest rowna ilosci danych ostatnije warstwy funkcja zwraca false
            if ((input.Count != this.Layers[0].Neurons.Count) || (output.Count != this.Layers[this.Layers.Count - 1].Neurons.Count )) return false;

            //Przypisanie, oraz przetworzenie danych oraz wartosci neuronow
            Run(input);

            
            //Dla wszystkich neuronow ostatniej warstwy
            for(int i = 0; i< this.Layers[thisLayers.Count - 1].Neurons.Count; i++)
            {
                //Pobranie aktualnego neuronu
                Neuron neuron = this.Layers[this.Layers.Count - 1].Neurons[i];
                //Policzenie mu delty 
                neuron.Delta = neuron.Value * (1 - neuron.Value) * (output[i] - neuron.Value);

                //Petla jakas ... jutro bo nie mysle
                for(int j = this.Layers.Count - 2; j > 2; j--)
                {

                }

            }

        }




        
    }
}
