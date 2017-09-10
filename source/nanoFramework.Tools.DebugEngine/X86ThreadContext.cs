using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanoFramework.Tools.DebugEngine
{
    public sealed class X86ThreadContext
    {
        public uint eax;
        public uint ebx;
        public uint ecx;
        public uint edx;
        public uint esi;
        public uint edi;
        public uint eip;
        public uint esp;
        public uint ebp;
        public uint EFlags;
    }
}
