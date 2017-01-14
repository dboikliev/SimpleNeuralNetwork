namespace SimpleNeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var network = new NeuralNetwork(2, 5, 1);
            network.Train(new[]
            {
                new[] {0D, 0D},
                new[] {0D, 1D},
                new[] {1D, 0D},
                new[] {1D, 1D},
            }, new[]
            {
                new[] {0D},
                new[] {1D},
                new[] {1D},
                new[] {0D},
            }, 50000, 0.01);

        }
    }
}