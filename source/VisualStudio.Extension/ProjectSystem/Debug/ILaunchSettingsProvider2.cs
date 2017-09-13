﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    ///     Provides an implementation of <see cref="ILaunchSettingsProvider"/> with an
    ///     additional method <see cref="GetLaunchSettingsFilePathAsync"/> for retrieving
    ///     the launch settings file.
    /// </summary>
    public interface ILaunchSettingsProvider2 : ILaunchSettingsProvider
    {
        /// <summary>
        ///     Gets the full path to the launch settings file, typically located under
        ///     "Properties\launchSettings.json" or "My Project\launchSettings.json" of
        ///     the project directory.
        /// </summary>
        Task<string> GetLaunchSettingsFilePathAsync();
    }
}
