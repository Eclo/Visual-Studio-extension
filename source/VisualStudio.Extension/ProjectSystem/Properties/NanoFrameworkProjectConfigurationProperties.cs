//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using Microsoft;
using Microsoft.VisualStudio.ProjectSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSLangProj;
using VSLangProj110;
using VSLangProj80;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    [Export(ExportContractNames.VsTypes.ConfiguredProjectPropertiesAutomationObject)]
    [Order(10)]
    [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
    public class NanoFrameworkProjectConfigurationProperties : 
                CSharpProjectConfigurationProperties3,
                CSharpProjectConfigurationProperties6
    {
        private readonly ProjectProperties _projectProperties;
        private readonly IProjectThreadingService _threadingService;


        public string LanguageVersion
        {
            get
            {
                return _threadingService.ExecuteSynchronously(async () =>
                {
                    var browseObjectProperties = await _projectProperties.GetConfiguredBrowseObjectPropertiesAsync().ConfigureAwait(true);
                    return await browseObjectProperties.LangVersion.GetEvaluatedValueAtEndAsync().ConfigureAwait(true);
                });
            }

            set
            {
                _threadingService.ExecuteSynchronously(async () =>
                {
                    var browseObjectProperties = await _projectProperties.GetConfiguredBrowseObjectPropertiesAsync().ConfigureAwait(true);
                    await browseObjectProperties.LangVersion.SetValueAsync(value).ConfigureAwait(true);
                });
            }
        }

        public string CodeAnalysisRuleSet
        {
            get
            {
                return _threadingService.ExecuteSynchronously(async () =>
                {
                    var browseObjectProperties = await _projectProperties.GetConfiguredBrowseObjectPropertiesAsync().ConfigureAwait(true);
                    return await browseObjectProperties.CodeAnalysisRuleSet.GetEvaluatedValueAtEndAsync().ConfigureAwait(true);
                });
            }

            set
            {
                _threadingService.ExecuteSynchronously(async () =>
                {
                    var browseObjectProperties = await _projectProperties.GetConfiguredBrowseObjectPropertiesAsync().ConfigureAwait(true);
                    await browseObjectProperties.CodeAnalysisRuleSet.SetValueAsync(value).ConfigureAwait(true);
                });
            }
        }

        [ImportingConstructor]
        internal NanoFrameworkProjectConfigurationProperties(
            ProjectProperties projectProperties,
            IProjectThreadingService threadingService)
        {
            Requires.NotNull(projectProperties, nameof(projectProperties));
            Requires.NotNull(threadingService, nameof(threadingService));

            _projectProperties = projectProperties;
            _threadingService = threadingService;
        }


        public object ExtenderNames => null;
        public string __id => throw new System.NotImplementedException();
        public bool DebugSymbols { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool DefineDebug { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool DefineTrace { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string OutputPath { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string IntermediatePath { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string DefineConstants { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool RemoveIntegerChecks { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public uint BaseAddress { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool AllowUnsafeBlocks { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CheckForOverflowUnderflow { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string DocumentationFile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool Optimize { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool IncrementalBuild { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StartProgram { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StartWorkingDirectory { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StartURL { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StartPage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string StartArguments { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool StartWithIE { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool EnableASPDebugging { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool EnableASPXDebugging { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool EnableUnmanagedDebugging { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public prjStartAction StartAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public object get_Extender(string arg)
        {
            throw new System.NotImplementedException();
        }
        public string ExtenderCATID => throw new System.NotImplementedException();
        public prjWarningLevel WarningLevel { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool TreatWarningsAsErrors { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool EnableSQLServerDebugging { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public uint FileAlignment { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool RegisterForComInterop { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string ConfigurationOverrideFile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool RemoteDebugEnabled { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string RemoteDebugMachine { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string NoWarn { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool NoStdLib { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string DebugInfo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string PlatformTarget { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string TreatSpecificWarningsAsErrors { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool RunCodeAnalysis { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisLogFile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisRuleAssemblies { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisInputAssembly { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisRules { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisSpellCheckLanguages { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisUseTypeNameInSuppression { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisModuleSuppressionsFile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool UseVSHostingProcess { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public sgenGenerationOption GenerateSerializationAssemblies { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisIgnoreGeneratedCode { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisOverrideRuleVisibilities { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisDictionaries { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisCulture { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisRuleSetDirectories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisIgnoreBuiltInRuleSets { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string CodeAnalysisRuleDirectories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisIgnoreBuiltInRules { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool CodeAnalysisFailOnMissingRules { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public bool Prefer32Bit { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string ErrorReport { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
