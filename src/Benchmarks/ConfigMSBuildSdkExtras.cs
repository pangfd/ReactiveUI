// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.DotNetCli;
using BenchmarkDotNet.Toolchains.MsBuildSdkExtras;

namespace ReactiveUI.Benchmarks
{
    internal class ConfigMSBuildSdkExtras : ManualConfig
    {
        public ConfigMSBuildSdkExtras()
        {
            Add(Job.Default
                .With(Platform.X64)
                .With(Jit.RyuJit)
                .With(MsBuildSdkExtrasToolchain.From(NetCoreAppSettings.NetCoreApp21)));
        }
    }
}
