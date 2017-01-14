using System;

namespace SimpleNeuralNetwork
{
    class Layer
    {
        public Neuron[] Neurons { get; }

        public Layer(int size, Layer previous = null)
        {
            Neurons = new Neuron[size + 1];
            for (int i = 0; i < Neurons.Length - 1; i++)
            {
                Neurons[i] = new Neuron(previous);
            }

            Neurons[Neurons.Length - 1] = new Neuron();
        }

        private double sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }
    }
}
