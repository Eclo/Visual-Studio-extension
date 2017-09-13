﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    ///     Provides access to a required Visual Studio proffered service.
    /// </summary>
    /// <typeparam name="TService">
    ///     The type of the service to retrieve.
    /// </typeparam>
    /// <typeparam name="TInterface">
    ///     The type of the service to return from <see cref="IVsService{T}.Value"/>
    /// </typeparam>
    internal interface IVsService<TService, TInterface> : IVsService<TInterface>
    {
    }
}