// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI.Benchmarks.Mocks
{
    /// <summary>
    /// A mock that wraps a ObservableAsPropertyHelper property.
    /// </summary>
    public class MockOAPHViewModel : ReactiveObject
    {
        private readonly ObservableAsPropertyHelper<bool> _myVar1;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockOAPHViewModel"/> class.
        /// </summary>
        public MockOAPHViewModel()
        {
            _myVar1 = Observable.Never<bool>().ToProperty(this, nameof(MyProperty1));
        }

        /// <summary>
        /// Gets a value indicating whether the OAPH value is set.
        /// </summary>
        public bool MyProperty1 => _myVar1.Value;
    }
}
