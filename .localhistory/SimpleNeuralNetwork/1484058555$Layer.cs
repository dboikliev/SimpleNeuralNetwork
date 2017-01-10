namespace SimpleNeuralNetwork
{
    class Layer
    {
        public Neuron[] Neurons { get; }

        public Layer(int size, Layer previous = null)
        {
            Neurons = new Neuron[size];

            for (int i = 0; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron(previous);

            }
        }
    }
}
