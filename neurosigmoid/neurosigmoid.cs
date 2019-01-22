using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neurosigmoid
{
    public partial class neurosigmoid : Form
    {
        private List<double> input;
        private List<double> output;
        private NeuralNetwork network;
        int firstLayerNeuronsCount;
        int secondLayerNeuronsCount;
        double learningRate;
        int cycles;

        public neurosigmoid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            firstLayerNeuronsCount = int.Parse(textBox1.Text);
            secondLayerNeuronsCount = int.Parse(textBox2.Text);
            learningRate = double.Parse(textBox4.Text);
            cycles = int.Parse(textBox3.Text);

            

            //Wejscie
            input = new List<double>();
            input.Add(0000000000000000000);
            input.Add(0000000010100100001);
            input.Add(0010000101001000101);
            input.Add(0100001000001100001);
            input.Add(0010001101001000001);
            input.Add(0000000010100100001);
            input.Add(0010010001001000110);
            input.Add(0110010101001011110);
            input.Add(0010011001001000110);
            input.Add(1000011101001001110);
            input.Add(1010100001001000110);
            input.Add(1100100101001001110);
            input.Add(0000101001010011111);
            input.Add(0110101101001000110);
            input.Add(0000110001001000110);
            input.Add(0010110111001000000);
            input.Add(0100111001001000110);
            input.Add(0110111101001000110);
            input.Add(0110110001001011110);
            input.Add(1001000001001000010);
            input.Add(0111000111001000001);
            input.Add(1001001001001000011);
            input.Add(1011001100110110101);
            input.Add(1100111101001000110);
            input.Add(1111010001001000111);
            input.Add(0001010111001001101);
            input.Add(0001011011010100000);
            input.Add(0010110111010100000);
            input.Add(0011001001001010111);

            //Wyjscie
            output = new List<double>();
            output.Add(00000);
            output.Add(00001);
            output.Add(00010);
            output.Add(00011);
            output.Add(00100);
            output.Add(00101);
            output.Add(00110);
            output.Add(00111);
            output.Add(01000);
            output.Add(01001);
            output.Add(01010);
            output.Add(01011);
            output.Add(01100);
            output.Add(01101);
            output.Add(01110);
            output.Add(01111);
            output.Add(10000);
            output.Add(10001);
            output.Add(10010);
            output.Add(10011);
            output.Add(10100);
            output.Add(10101);
            output.Add(10110);
            output.Add(10111);
            output.Add(11000);
            output.Add(11001);
            output.Add(11010);
            output.Add(11011);
            output.Add(11100);

            network = new NeuralNetwork(learningRate, new int[] { 2, firstLayerNeuronsCount, secondLayerNeuronsCount, 2 });

            //Draw structure
            DrawNetworkStructure(networkGraph, 150, networkGraph.Height - 45, 30, 60, 60, Color.Purple, Color.Red, Color.Green);
            updateTreeView(treeView1);
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            
            cycles = int.Parse(textBox3.Text);
            updateTreeView(treeView1);

            for (int i = 1; i <= cycles; i++)
            {
                network.Train(ref input, ref output);
                Application.DoEvents();
                textBox3.Text = i + "/" + cycles.ToString();
                updateTreeViewValues(treeView1);
                DrawNetworkStructure(networkGraph, 150, networkGraph.Height - 45, 30, 60, 60, Color.Purple, Color.Red, Color.Green);
                if (i == cycles) break;
            }

        }


        private void DrawNetworkStructure(PictureBox pb, int startX, int startY, int scale, int hspace, int vspace, Color iColor, Color hColor, Color oColor)
        {
            //Stworzenie bitmay i obiektu graficznego dla PictureBox
            Bitmap b = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(b);


            //Rysowanie
            g.Clear(Color.White);

            //Warstwy
            for (int i = 0; i < network.Layers.Count; i++)
            {
                int x = startX - hspace * (network.Layers[i].Neurons.Count/2);
                int y = startY - (vspace * i);

                //Neurony
                for (int k = 0; k < network.Layers[i].Neurons.Count ; k++)
                {
                    if(i == 0)
                    {
                        SolidBrush brush = new SolidBrush(iColor);
                        Pen pen =  new Pen(iColor);
                        g.DrawEllipse(pen, x, y, scale, scale);
                        g.FillEllipse(brush, x, y, scale, scale);
                        g.DrawString("Wy", new Font(new FontFamily("Arial"), 10f), Brushes.White, x , y);
                    }
                    else if (i == network.Layers.Count - 1)
                    {
                        SolidBrush brush = new SolidBrush(oColor);
                        Pen pen = new Pen(oColor);
                        g.DrawEllipse(pen, x, y, scale, scale);
                        g.FillEllipse(brush, x, y, scale, scale);
                        g.DrawString("We", new Font(new FontFamily("Arial"), 10f), Brushes.White, x , y);
                    }
                    else
                    {
                        SolidBrush brush = new SolidBrush(hColor);
                        Pen pen = new Pen(hColor);
                        g.DrawEllipse(pen, x, y, scale, scale);
                        g.FillEllipse(brush, x, y, scale, scale);
                        //g.DrawString(i.ToString(), new Font(new FontFamily("Arial"), 10f), Brushes.White, x, y);
                    }
                    
                    if( i > 0)
                    {
                        int denX1 = x + (scale / 2);
                        int denY1 = y + scale;
                        int denX2 = (startX - hspace * (network.Layers[i - 1].Neurons.Count / 2)) + (scale / 2);
                        int denY2 = y + vspace;

                        for (int j = 0; j < network.Layers[i].Neurons[k].Dendrites.Count; j++)
                        {
                            Pen pen = new Pen(Color.Gray, 1.25f);
                            g.DrawLine(pen, denX1, denY1, denX2, denY2);
                            denX2 = denX2 + hspace;
                            g.DrawString(network.Layers[i].Neurons[k].Dendrites[j].Weight.ToString().Substring(0,5), new Font(new FontFamily("Arial"), 8f), Brushes.Black, x+20, y+20);
                        }


                    }
                    x = x + hspace;
                }


            }

            //przypisanie grafiki do komponentu
            pb.Image = b;
        }

        private void updateTreeView(TreeView tv)
        {
            tv.Nodes.Clear();

            for (int i = 0; i < network.Layers.Count; i++)
            {
                if (i == 0) tv.Nodes.Add("Warstwa Wejsciowa ");
                else if(i == network.Layers.Count-1) tv.Nodes.Add("Warstwa Wyjsciowa ");
                else tv.Nodes.Add("Warstwa " + i.ToString());
                
                
                for(int j = 0; j < network.Layers[i].Neurons.Count; j++)
                {
                    tv.Nodes[i].Nodes.Add("Neuron " + i.ToString() + "/" + j.ToString());
                    tv.Nodes[i].Nodes[j].Nodes.Add("Delta: " + network.Layers[i].Neurons[j].Delta + " / Bias: " + network.Layers[i].Neurons[j].Bias + " / Wartość: " + network.Layers[i].Neurons[j].Value);
                }

                tv.Nodes[i].ExpandAll();
            }
        }

        private void updateTreeViewValues(TreeView tv)
        {
            for (int i = 0; i < network.Layers.Count; i++)
            {
                for (int j = 0; j < network.Layers[i].Neurons.Count; j++)
                {
                    tv.Nodes[i].Nodes[j].Nodes[0].Text = "Delta: " + network.Layers[i].Neurons[j].Delta + " / Bias: " + network.Layers[i].Neurons[j].Bias + " / Wartość: " + network.Layers[i].Neurons[j].Value;
                }

                tv.Nodes[i].ExpandAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstLayerNeuronsCount = int.Parse(textBox1.Text);
            secondLayerNeuronsCount = int.Parse(textBox2.Text);
            learningRate = double.Parse(textBox4.Text);
            cycles = int.Parse(textBox3.Text);

            network = new NeuralNetwork(learningRate, new int[] { 2, firstLayerNeuronsCount, secondLayerNeuronsCount, 2 });
            DrawNetworkStructure(networkGraph, 150, networkGraph.Height - 45, 20, 30, 30, Color.Purple, Color.Red, Color.Green);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
                double [] netOutput = network.Run(input);
                Application.DoEvents();
                updateTreeViewValues(treeView1);
        }
    }
}
