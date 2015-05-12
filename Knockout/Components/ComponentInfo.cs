using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Html;
using System.Xml;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    public class ComponentInfo
    {
        [IntrinsicProperty]
        [ScriptName("element")]
        public HtmlElement Element { get; set; }

        [IntrinsicProperty]
        [ScriptName("templateNodes")]
        public List<XmlNode> TemplateNodes { get; set; }
    }
}
