using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Microsoft.VisualStudio.ProjectSystem;
using Microsoft.VisualStudio.ProjectSystem.Debug;
using Microsoft.VisualStudio.ProjectSystem.Properties;
using Microsoft.VisualStudio.ProjectSystem.VS.Debug;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    [ExportDebugger(NFDebugger.SchemaName)]
    [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
    public class NFDebuggerLaunchProvider : DebugLaunchProviderBase
    {
        [ImportingConstructor]
        public NFDebuggerLaunchProvider(ConfiguredProject configuredProject)
            : base(configuredProject)
        {
        }

        // TODO: Specify the assembly full name here
        [ExportPropertyXamlRuleDefinition("nanoFramework.Tools.VS2017.Extension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9be6e469bc4921f1", "XamlRuleToCode:NFDebugger.xaml", "Project")]
        [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
        private object DebuggerXaml { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets project properties that the debugger needs to launch.
        /// </summary>
        [Import]
        private ProjectProperties DebuggerProperties { get; set; }

        public override async Task<bool> CanLaunchAsync(DebugLaunchOptions launchOptions)
        {
            var properties = await this.DebuggerProperties.GetNFDebuggerPropertiesAsync();
            string commandValue = await properties.NFDebuggerCommand.GetEvaluatedValueAtEndAsync();
            return !string.IsNullOrEmpty(commandValue);
        }

        public override async Task<IReadOnlyList<IDebugLaunchSettings>> QueryDebugTargetsAsync(DebugLaunchOptions launchOptions)
        {
            var settings = new DebugLaunchSettings(launchOptions);

            // The properties that are available via DebuggerProperties are determined by the property XAML files in your project.
            var debuggerProperties = await this.DebuggerProperties.GetNFDebuggerPropertiesAsync();
            //settings.CurrentDirectory = await debuggerProperties.NFDebuggerWorkingDirectory.GetEvaluatedValueAtEndAsync();
            //settings.Executable = await debuggerProperties.NFDebuggerCommand.GetEvaluatedValueAtEndAsync();
            //settings.Arguments = await debuggerProperties.NFDebuggerCommandArguments.GetEvaluatedValueAtEndAsync();
            settings.LaunchOperation = DebugLaunchOperation.CreateProcess;

            // TODO: Specify the right debugger engine
            settings.LaunchDebugEngineGuid = DebuggerEngines.ManagedOnlyEngine;

            return new IDebugLaunchSettings[] { settings };
        }
    }
}
