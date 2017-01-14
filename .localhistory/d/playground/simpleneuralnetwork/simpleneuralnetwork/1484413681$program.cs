namespace SimpleNeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var network = new NeuralNetwork(4, 5, 1);
            network.Train(new[]
            {
                new [] { 0, 0 },
                new [] { 0, 1 },
                new [] { 1, 0 },
                new [] { 1, 1 },
            })
        }
    }
}
