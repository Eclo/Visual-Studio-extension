﻿//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Tools.VisualStudio.Extension
{
    using Microsoft;
    using Microsoft.VisualStudio.ProjectSystem;
    using Microsoft.VisualStudio.ProjectSystem.VS;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    using System;
    using System.ComponentModel.Composition;


    [Export]
    [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
    [ProjectTypeRegistration(GuidsStrings.NanoCSharpProjectType, "NanoCSharpProject", "#2", ProjectExtension, Language, resourcePackageGuid: NanoFrameworkPackage.PackageGuid, PossibleProjectExtensions = ProjectExtension, ProjectTemplatesDir = @"..\..\Templates\Projects\MyCustomProject")]
    [ProvideProjectItem(GuidsStrings.NanoCSharpProjectType, "NanoCSharpItems", @"..\..\Templates\ProjectItems\MyCustomProject", 500)]

    internal class NanoCSharpProjectUnconfigured
    {
        /// <summary>
        /// A project capability that is present in your project type and none others.
        /// This is a convenient constant that may be used by your extensions so they
        /// only apply to instances of your project type.
        /// </summary>
        /// <remarks>
        /// This value should be kept in sync with the capability as actually defined in your .targets.
        /// </remarks>
        internal const string UniqueCapability = "NanoCSharpProjectType";

        [ImportingConstructor]
        public NanoCSharpProjectUnconfigured(UnconfiguredProject unconfiguredProject)
        {
            Requires.NotNull(unconfiguredProject, nameof(unconfiguredProject));
            this.ProjectHierarchies = new OrderPrecedenceImportCollection<IVsHierarchy>(projectCapabilityCheckProvider: unconfiguredProject);
        }

        public Guid ProjectTypeGuid
        {
            get { return new Guid(GuidsStrings.NanoCSharpProjectType); }
        }

        [Import]
        internal UnconfiguredProject UnconfiguredProject { get; private set; }

        [Import]
        internal IActiveConfiguredProjectSubscriptionService SubscriptionService { get; private set; }

        [Import]
        internal IProjectThreadingService ProjectThreadingService { get; private set; }

        [Import]
        internal ActiveConfiguredProject<ConfiguredProject> ActiveConfiguredProject { get; private set; }

        [Import]
        internal ActiveConfiguredProject<NanoCSharpProjectConfigured> MyActiveConfiguredProject { get; private set; }

        [ImportMany(ExportContractNames.VsTypes.IVsProject, typeof(IVsProject))]
        internal OrderPrecedenceImportCollection<IVsHierarchy> ProjectHierarchies { get; private set; }

        internal IVsHierarchy ProjectHierarchy
        {
            get { return this.ProjectHierarchies.Single().Value; }
        }
    }

}
