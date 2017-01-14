namespace SimpleNeuralNetwork
{
    class Neuron
    {
        private Connection[] _connections;

        public Neuron(Layer previous)
        {
            _connections = new Connection[previous.Neurons.Length];
            for (int i = 0; i < _connections.Length; i++)
            {
                _connections[i] = new Connection(previous.Neurons[i]);
            }
        }
    }
}
