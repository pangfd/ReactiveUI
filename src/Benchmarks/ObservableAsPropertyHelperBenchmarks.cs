// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ReactiveUI.Benchmarks.Mocks;

namespace ReactiveUI.Benchmarks
{
    /// <summary>
    /// Benchmarks for the ObservableAsPropertyHelper class.
    /// </summary>
    [Config(typeof(ConfigMSBuildSdkExtras))]
    [MemoryDiagnoser]
    public class ObservableAsPropertyHelperBenchmarks
    {
        /// <summary>
        /// Benchmark for getting and using the NavigatedTo observable.
        /// </summary>
        [Benchmark]
        public void Create()
        {
            var items = new List<MockOAPHViewModel>();
            for (int i = 0; i < 3000; i++)
            {
                items.Add(new MockOAPHViewModel());
            }
        }
    }
}
