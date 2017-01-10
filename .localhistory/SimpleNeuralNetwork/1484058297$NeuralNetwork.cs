namespace SimpleNeuralNetwork
{
    class NeuralNetwork
    {
        private Layer _inputLayer;
        private Layer[] _hiddenLayers;
        private Layer _outputLayer;

        public NeuralNetwork(params int[] layerSizes)
        {
            if (layerSizes.Length == 2)
            {
                _inputLayer = new Layer[layerSizes[0]];
            }
        }
    }
}
