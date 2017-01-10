namespace SimpleNeuralNetwork
{
    class Layer
    {
        private Neuron[] _neurons;

        public Layer(int size, Layer previous = null)
        {
            _neurons = new Neuron[size];

            for (int i = 0; i < _neurons.Length; i++)
            {
                _neurons[i] = new Neuron()
            }
        }
    }
}
