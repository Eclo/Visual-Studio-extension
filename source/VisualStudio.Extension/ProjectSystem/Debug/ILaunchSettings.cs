﻿
using System.Collections.Immutable;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    /// Interface definition for an immutable launch settings snapshot.
    /// </summary>
    public interface ILaunchSettings
    {
        ILaunchProfile ActiveProfile { get; }

        /// <summary>
        /// Access to the current set of launch profiles
        /// </summary>
        ImmutableList<ILaunchProfile> Profiles { get; }

        /// <summary>
        /// Provides access to custom global launch settings data. The returned value depends
        /// on the section being retrieved. The settingsName matches the section in the
        /// settings file
        /// 
        /// </summary>
        object GetGlobalSetting(string settingsName);

        /// <summary>
        /// Provides access to all the global settings
        /// </summary>
        ImmutableDictionary<string, object> GlobalSettings { get; }
    }
}
