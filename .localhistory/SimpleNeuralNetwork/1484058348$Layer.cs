namespace SimpleNeuralNetwork
{
    class Layer
    {
        private Neuron[] _neurons;

        public Layer(int size)
        {
            _neurons = new Neuron[size];
        }
    }
}
