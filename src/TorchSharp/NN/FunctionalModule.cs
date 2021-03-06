﻿using System;
using System.Collections.Generic;
using TorchSharp.Tensor;

namespace TorchSharp.NN
{
    /// <summary>
    /// This class is used to represent a functional module (e.g., ReLU).
    /// </summary>
    public abstract class FunctionalModule<T> : ProvidedModule
    {
        internal FunctionalModule() : base(IntPtr.Zero)
        {
        }

        public override void RegisterModule(Module module)
        {
        }

        public override void ZeroGrad()
        {
        }

        public override IEnumerable<(string name, TorchTensor parameter)> NamedParameters()
        {
            return new List<(string, TorchTensor)>();
        }

        public override IEnumerable<TorchTensor> Parameters()
        {
            return new List<TorchTensor>();
        }

        public override IEnumerable<string> GetModules()
        {
            return new string[0];
        }

        public override string GetName()
        {
            return typeof(T).Name;
        }
    }
}
