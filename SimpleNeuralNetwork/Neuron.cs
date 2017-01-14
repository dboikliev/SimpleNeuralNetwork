using System;

namespace SimpleNeuralNetwork
{
    class Neuron
    {
        public Connection[] Connections { get; }

        public double Output { get; set; }

        public Neuron() { }

        public Neuron(Layer previous)
        {
            if (previous != null)
            {
                Connections = new Connection[previous.Neurons.Length];
                for (int i = 0; i < Connections.Length; i++)
                {
                    Connections[i] = new Connection(previous.Neurons[i]);
                }
            }
        }

        public void CalculateOutput()
        {
            var sum = 0D;

            for (int i = 0; i < Connections.Length; i++)
            {
                sum += Connections[i].Weight * Connections[i].Neuron.Output;
            }

            Output = Sigmoid(sum);
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }
    }
}