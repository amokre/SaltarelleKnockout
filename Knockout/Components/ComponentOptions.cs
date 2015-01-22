using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class ComponentOptions
    {
        [ObjectLiteral]
        public ComponentOptions() { }

        [IntrinsicProperty]
        [ScriptName("viewModel")]
        public object ViewModel { get; set; }

        [IntrinsicProperty]
        [ScriptName("viewModel")]
        public ViewModelOptions ViewModelOptions { get; set; }

        [IntrinsicProperty]
        [ScriptName("template")]
        public object Template { get; set; }

        [IntrinsicProperty]
        [ScriptName("template")]
        public TemplateOptions TemplateOptions { get; set; }
    }
}
