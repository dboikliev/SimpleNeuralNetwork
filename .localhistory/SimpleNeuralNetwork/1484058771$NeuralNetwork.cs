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

                for (int i = 1; i < layerSizes.Length - 1; i++)
                {
                    _hiddenLayers = new Layer(layerSizes[i],
                        i == 1 ? _inputLayer : _hiddenLayers[i - 1]);
                }

                _outputLayer = new Layer(layerSizes[layerSizes.Length - 1]);
            }
        }
    }
}
