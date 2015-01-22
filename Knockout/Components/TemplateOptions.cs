using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class TemplateOptions
    {
        [ObjectLiteral]
        public TemplateOptions() { }

        [IntrinsicProperty]
        [ScriptName("require")]
        public string Require { get; set; }
    }
}
