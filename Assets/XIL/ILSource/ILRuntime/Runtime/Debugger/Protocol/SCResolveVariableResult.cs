#if USE_ILRT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILRuntime.Runtime.Debugger.Protocol
{
    public class SCResolveVariableResult
    {
        public VariableInfo Info { get; set; }
    }
}

#endif