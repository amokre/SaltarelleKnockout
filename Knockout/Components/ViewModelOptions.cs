using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class ViewModelOptions
    {
        [ObjectLiteral]
        public ViewModelOptions() { }

        [IntrinsicProperty]
        [ScriptName("createViewModel")]
        public Func<JsDictionary<string, object>, ComponentInfo, object> CreateViewModel { get; set; }
        
        [IntrinsicProperty]
        [ScriptName("instance")]
        public object Instance { get; set; }

        [IntrinsicProperty]
        [ScriptName("require")]
        public string Require { get; set; }
    }
}
