namespace SimpleNeuralNetwork
{
    class Connection
    {
        public Neuron Neuron { get; }
        public double Weight { get; set; } = RNG.NextDouble();

        public Connection(Neuron neuron)
        {
            Neuron = neuron;
        }
    }
}
