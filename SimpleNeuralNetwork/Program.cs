namespace SimpleNeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {

            var net = new NeuralNetwork(2, 50, 1);
            net.Train(new[]
            {
                new [] { 0D, 0D },
                new [] { 1D, 0D },
                new [] { 0D, 1D },
                new [] { 1D, 1D },
            }, new[]
            {
                new [] { 0D },
                new [] { 1D },
                new [] { 1D },
                new [] { 1D },
            }, 50000, 0.001);

            for (int i = 0; i < 1; i++)
            {
                var results = net.Run(new[]
                {
                    new[] { 0D, 0D }
                });
                System.Console.WriteLine("{0:0.##########################################}", results[0]);
            }

        }
    }
}
