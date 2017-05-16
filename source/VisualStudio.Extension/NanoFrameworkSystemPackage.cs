//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//
// We register this as the nanoFramework "project type"
using Microsoft.VisualStudio.ProjectSystem;
using Microsoft.VisualStudio.ProjectSystem.VS;
using nanoFramework.Tools.VisualStudio.Extension;

[assembly: ProjectTypeRegistration(
        projectTypeGuid: GuidsStrings.NanoCSharpProjectType,
        displayName: "#1",
        displayProjectFileExtensions: "#2",
        /// The file extension used by your project type.
        /// This does not include the leading period.
        defaultProjectExtension: "nfproj",
        language: "CSharp", 
        resourcePackageGuid: NanoFrameworkSystemPackage.PackageGuid, 
        Capabilities = 
            ProjectCapabilities.CSharp + ";" +
            ProjectCapabilities.ProjectConfigurationsInferredFromUsage + ";" +
            ProjectCapabilities.PackageReferences + ";" +
            ProjectCapabilities.AssemblyReferences + ";" +
            NanoCSharpProjectUnconfigured.UniqueCapability,
        ProjectTemplatesDir = @"..\..\Templates\Projects\MyCustomProject")]

namespace nanoFramework.Tools.VisualStudio.Extension
{
    using Microsoft.VisualStudio.Shell;
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    /// <summary>
    /// This class implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// This package is required if you want to define adds custom commands (ctmenu)
    /// or localized resources for the strings that appear in the New Project and Open Project dialogs.
    /// Creating project extensions or project types does not actually require a VSPackage.
    /// </remarks>
    [PackageRegistration(AllowsBackgroundLoading = true, RegisterUsing = RegistrationMethod.CodeBase, UseManagedResourcesOnly = true)]
    [Description("Visual Studio 2017 extension for nanoFramework. Enables creating C# Solutions to be deployed to a target board and provides debugging tools.")]
    [Guid(NanoFrameworkSystemPackage.PackageGuid)]
    public sealed class NanoFrameworkSystemPackage : AsyncPackage
    {
        /// <summary>
        /// The GUID for this package.
        /// </summary>
        public const string PackageGuid = "23C2F819-1E4B-4012-98E9-8DB86E5F351D";


        public NanoFrameworkSystemPackage()
        {
        }
    }
}
