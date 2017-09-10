using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanoFramework.Tools.DebugEngine
{
    public sealed class VariableInformation
    {
        public string m_name;
        public string m_typeName;
        public string m_value;
        public bool m_fUserDefinedType;
        public uint m_dwBaseType;
        public uint m_dwIndirectionLevel;
        public bool m_fFrameRelative;
        public uint m_address;
        public VariableInformation child;

        //public static VariableInformation Create(DebuggedProcess debuggedProcess, uint bp, char* bstrVarName, char* bstrVarType, bool fBuiltInType, uint dwOffset, uint dwIndirectionLevel)
        //{

        //}

    }
}
