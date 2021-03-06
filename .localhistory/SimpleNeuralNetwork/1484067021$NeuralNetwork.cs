﻿using System;

namespace SimpleNeuralNetwork
{
    class NeuralNetwork
    {
        private Layer _inputLayer;
        private Layer[] _hiddenLayers;
        private Layer _outputLayer;

        private double epsilon = double.Epsilon;

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

        public void Train(double[][] inputs, double[][] expectedOutpus, int maxSteps, double maxError)
        {
            var error = double.MaxValue;
            for (int i = 0; i < maxSteps || error < maxError; i++)
            {
                for (int m = 0; m < inputs.Length; m++)
                {
                    for (int j = 0; j < _inputLayer.Neurons.Length; j++)
                    {
                        _inputLayer.Neurons[j].Output = inputs[m][j];
                    }

                    for (int j = 0; j < _hiddenLayers.Length; j++)
                    {
                        for (int k = 0; k < _hiddenLayers[j].Neurons.Length; k++)
                        {
                            _hiddenLayers[j].Neurons[k].CalculateOutput();
                        }
                    }

                    for (int j = 0; j < _outputLayer.Neurons.Length; j++)
                    {
                        _outputLayer.Neurons[j].CalculateOutput();
                    }

                    //squared error
                    for (int j = 0; j < _outputLayer.Neurons.Length; j++)
                    {
                        error += Math.Pow(expectedOutpus[m][j] - _outputLayer.Neurons[j].Output, 2);
                    }

                    ApplyBackPropagation(expectedOutpus[m]);
                }
            }

        }

        private void ApplyBackPropagation(double[] expectedOutput)
        {
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                if (expectedOutput[i] < 0)
                {
                    expectedOutput[i] = 0 + epsilon;
                }
                else if (expectedOutput[i] > 1)
                {
                    expectedOutput[i]] = 1 - epsilon;
                }
            }
        }
    }
}
