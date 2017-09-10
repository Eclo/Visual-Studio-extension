using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanoFramework.Tools.DebugEngine
{
    public sealed class DebuggedModule : WorkerContainerObject
    {
        public readonly uint BaseAddress;
        public readonly uint Size;
        public readonly string Name;
        public bool SymbolsLoaded;
        public string SymbolPath;

        public uint GetLoadOrder() { return 0; }
    }
}
