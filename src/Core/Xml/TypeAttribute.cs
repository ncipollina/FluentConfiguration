using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class TypeAttribute : XAttribute
    {
        public TypeAttribute(string typeName) : base("type", typeName) { }
    }
}
