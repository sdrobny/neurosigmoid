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
        public neurosigmoid()
        {
            
            NeuralNetwork nn = new NeuralNetwork(21.5, new int[] { 2, 7, 6, 2 });

            List<double> input = new List<double>();
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

            List<double> output = new List<double>();
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

            nn.Train(input, output);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
