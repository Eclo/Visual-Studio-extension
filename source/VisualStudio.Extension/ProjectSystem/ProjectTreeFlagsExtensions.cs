using Microsoft.VisualStudio.ProjectSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    ///     Provides extension methods for <see cref="ProjectTreeFlags"/>.
    /// </summary>
    internal static class ProjectTreeFlagsExtensions
    {
        /// <summary>
        ///     Returns a value indicating whether the specified flags has the flag <see cref="ProjectTreeFlags.Common.ProjectRoot"/>.
        /// </summary>
        public static bool IsProjectRoot(this ProjectTreeFlags flags)
        {
            return flags.HasFlag(ProjectTreeFlags.Common.ProjectRoot);
        }

        /// <summary>
        ///     Returns a value indicating whether the specified flags has the specified flag.
        /// </summary>
        public static bool HasFlag(this ProjectTreeFlags flags, ProjectTreeFlags.Common flag)
        {
            return flags.Contains(flag);
        }
    }
}
