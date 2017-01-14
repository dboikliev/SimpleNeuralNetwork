namespace SimpleNeuralNetwork
{
    class NeuralNetwork
    {
        private Layer _inputLayer;
        private Layer[] _hiddenLayers;
        private Layer _outputLayer;

        public NeuralNetwork(params int[] layerSizes)
        {
            if (layerSizes.Length >= 2)
            {
                _inputLayer = new Layer(layerSizes[0]);
                Layer previous;
                for (int i = 1; i < layerSizes.Length - 1; i++)
                {
                    previous = i == 1 ? _inputLayer : _hiddenLayers[i - 1];
                    _hiddenLayers[i] = new Layer(layerSizes[i], previous);
                }

                previous = layerSizes.Length > 2
                    ? _hiddenLayers[_hiddenLayers.Length - 1]
                    : _inputLayer;
                _outputLayer = new Layer(layerSizes[layerSizes.Length - 1], previous);
            }
        }

        public void Train(double[] input, double[] output, int maxSteps, double maxError)
        {
            var error = double.MaxValue;
            for (int i = 0; i < maxSteps || error < maxError; i++)
            {
                for (int j = 0; j < _inputLayer.Neurons.Length; j++)
                {
                    _inputLayer.Neurons[j].Output
                }
            }
        }
    }
}
