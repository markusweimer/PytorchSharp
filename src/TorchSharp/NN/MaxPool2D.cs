﻿using System;
using System.Runtime.InteropServices;
using TorchSharp.Tensor;

namespace TorchSharp.NN
{
    /// <summary>
    /// This class is used to represent a ReLu module.
    /// </summary>
    public class MaxPool2D : FunctionalModule<MaxPool2D>
    {
        private readonly long[] _kernelSize;
        private readonly long[] _stride;

        internal MaxPool2D(long[] kernelSize, long[] stride) : base()
        {
            _kernelSize = kernelSize;
            _stride = stride?? new long[0];
        }

        [DllImport("LibTorchSharp")]
        private static extern IntPtr THSNN_maxPool2DApply(IntPtr tensor, int kernelSizeLength, long[] kernelSize, int strideLength, long[] stride);

        public override TorchTensor Forward(TorchTensor tensor)
        {
            return new TorchTensor(THSNN_maxPool2DApply(tensor.Handle, _kernelSize.Length, _kernelSize, _stride.Length, _stride));
        }
    }
}
