namespace SimpleNeuralNetwork
{
    class Layer
    {
        public Neuron[] Neurons { get; }

        public Layer(int size, Layer previous = null)
        {
            Neurons = new Neuron[size + 1];
            Neurons[0] = new Neuron();
            for (int i = 1; i < Neurons.Length; i++)
            {
                Neurons[i] = new Neuron(previous);
            }
        }
    }
}
