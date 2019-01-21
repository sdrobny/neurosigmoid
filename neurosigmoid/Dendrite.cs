using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neurosigmoid
{
    class Dendrite
    {
        public double Weight { get; set; }

        public Dendrite()
        {
            // generowanie losowych wag dla inicjalizacji podczas startu programu
            CryptoRandom crand = new CryptoRandom();
            this.Weight = crand.RandValue;
        }
    }
}
