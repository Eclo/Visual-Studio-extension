//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using Microsoft.VisualStudio.ProjectSystem;
using Microsoft.VisualStudio.ProjectSystem.Build;
using System.ComponentModel.Composition;
using System.IO;
using System.Threading;

namespace nanoFramework.Tools.VisualStudio.Extension
{
    [Export(typeof(IDeployProvider))]
    [AppliesTo(NanoCSharpProjectUnconfigured.UniqueCapability)]
    public class DeployProvider : IDeployProvider
    {
        /// <summary>
        /// Provides access to the project's properties.
        /// </summary>
        [Import]
        private ProjectProperties Properties { get; set; }

        public async System.Threading.Tasks.Task DeployAsync(CancellationToken cancellationToken, TextWriter outputPaneWriter)
        {
            // Add your custom deploy code here. Write informational output to the outputPaneWriter.
            await outputPaneWriter.WriteAsync("Hello Deploy!!!");
            await Deploy(outputPaneWriter);
            await outputPaneWriter.WriteAsync("Get back to work!");

        }

        private async System.Threading.Tasks.Task Deploy(TextWriter outputPaneWriter)
        {
        }

        public bool IsDeploySupported => true;

        public void Commit()
        {
        }

        public void Rollback()
        {
        }
    }
}
