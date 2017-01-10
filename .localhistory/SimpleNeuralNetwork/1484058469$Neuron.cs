namespace SimpleNeuralNetwork
{
    class Neuron
    {
        private Layer _previous;

        public Neuron(Layer previous)
        {
            ._previous = previous;
        }
    }
}
