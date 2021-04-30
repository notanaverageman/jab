// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Jab.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Specification.Fakes;
using Xunit;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    public class ServiceProviderEngineScopeTests
    {
        [Fact]
        public void DoubleDisposeWorks()
        {
            var provider = new ServiceProvider(new ServiceCollection(), ServiceProviderOptions.Default);
            var serviceProviderEngineScope = new ServiceProviderEngineScope(provider);
            serviceProviderEngineScope.ResolvedServices.Add(new ServiceCacheKey(typeof(IFakeService), 0), null);
            serviceProviderEngineScope.Dispose();
            serviceProviderEngineScope.Dispose();
        }
    }
}
