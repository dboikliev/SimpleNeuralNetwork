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
    }
}
