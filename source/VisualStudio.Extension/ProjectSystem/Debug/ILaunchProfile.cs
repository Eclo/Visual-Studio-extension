
using System.Collections.Immutable;

namespace nanoFramework.Tools.VisualStudio.Extension
{

    /// <summary>
    /// Interface definition for a profile
    /// </summary>
    public interface ILaunchProfile
    {
        string Name { get; }
        string CommandName { get; }
        string ExecutablePath { get; }
        string CommandLineArgs { get; }
        string WorkingDirectory { get; }
        bool LaunchBrowser { get; }
        string LaunchUrl { get; }
        ImmutableDictionary<string, string> EnvironmentVariables { get; }
        ImmutableDictionary<string, object> OtherSettings { get; }
    }
}
