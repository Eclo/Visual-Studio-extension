//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using Microsoft;
using Microsoft.VisualStudio.ProjectSystem;
using System;
using System.ComponentModel.Composition;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    /// <summary>
    ///     Provides the nanoFramework implementation of <see cref="IItemTypeGuidProvider"/>.
    /// </summary>
    [Export(typeof(IItemTypeGuidProvider))]
    [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
    public class NanoFrameworkProjectGuidProvider : IItemTypeGuidProvider
    {
        private static readonly Guid _nanoFrameworkProjectType = new Guid(GuidsStrings.NanoCSharpProjectType);

        [ImportingConstructor]
        public NanoFrameworkProjectGuidProvider(UnconfiguredProject unconfiguredProject)
        {
            Requires.NotNull(unconfiguredProject, nameof(unconfiguredProject));
        }

        public Guid ProjectTypeGuid
        {
            get { return _nanoFrameworkProjectType; }
        }
    }
}
