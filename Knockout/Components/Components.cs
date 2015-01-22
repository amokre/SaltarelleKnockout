using System;
using System.Runtime.CompilerServices;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    public class Components
    {
        [ScriptName("register")]
        [InlineCode("ko.components.register({componentName}, {options})")]
        public void Register(string componentName, ComponentOptions options) { throw new NotSupportedException(); }
    }
}