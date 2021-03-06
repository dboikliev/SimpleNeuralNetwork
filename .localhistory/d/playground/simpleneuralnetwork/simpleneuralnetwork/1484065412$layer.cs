﻿namespace SimpleNeuralNetwork
{
    class Layer
    {
        public Neuron[] Neurons { get; }

        public Layer(int size, Layer previous = null)
        {
            Neurons = new Neuron[size + 1];

            for (int i = 1; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron(previous);
            }
        }
    }
}
