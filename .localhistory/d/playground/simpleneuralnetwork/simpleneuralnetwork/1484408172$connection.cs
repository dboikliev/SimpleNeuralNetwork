namespace SimpleNeuralNetwork
{
    class Connection
    {
        public Neuron Neuron { get; }
        public double Weight { get; set; }

        public Connection(Neuron neuron)
        {
            Neuron = neuron;
        }
    }
}
