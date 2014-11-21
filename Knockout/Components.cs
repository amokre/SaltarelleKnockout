using System;
using System.Runtime.CompilerServices;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    public class Components
    {
        [ScriptName("register")]
        public void Register(string componentName, dynamic options) { throw new NotSupportedException(); }
    }
}