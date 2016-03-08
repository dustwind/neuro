using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuro1
{
    [Serializable]
    class Weight
    {
        Neuron output;  //нейрон предыдущего слоя
        double w;       //рандомный вес

        public Weight (Neuron output, double rndnumber)
        {
            this.output = output;
            this.w = rndnumber;
        }

        public void setWeight(double w)
        {
            this.w = w;
        }

        public double getWeight()
        {
            return this.w;
        }

        public Neuron getOutput()
        {
            return this.output;
        }

        public void setOutNeuron(Neuron output)
        {
            this.output = output;
        }
    }
}
