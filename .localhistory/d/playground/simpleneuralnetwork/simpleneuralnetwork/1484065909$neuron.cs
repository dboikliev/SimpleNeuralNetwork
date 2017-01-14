using System;

namespace SimpleNeuralNetwork
{
    class Neuron
    {
        private Connection[] _connections;

        public double Weight { get; set; }

        public Neuron() { }

        public Neuron(Layer previous)
        {
            _connections = new Connection[previous.Neurons.Length];
            for (int i = 0; i < _connections.Length; i++)
            {
                _connections[i] = new Connection(previous.Neurons[i]);
            }
        }



        public void CalculateOutput()
        {
            var sum = 0D;

            for (int i = 0; i < _connections.Length; i++)
            {
                sum += _connections[i].Weight * _connections[i].Neuron.Weight;
            }

            this.Weight = Sigmoid(sum);
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }
    }
}
