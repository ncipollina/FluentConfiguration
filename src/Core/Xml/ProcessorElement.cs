using CapTech.FluentConfiguration.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class ProcessorElement : XElement
    {
        private string _typeName;

        private string _patchAfter;

        public ProcessorElement(string typeName) : base("processor")
        {
            Add(new TypeAttribute(typeName));
        }

        public ProcessorElement PatchInstead(string insteadType)
        {
            Add(new PatchInsteadAttribute(insteadType));
            return this;
        }

        public ProcessorElement PatchInstead(Type insteadType)
        {
            return PatchInstead(insteadType.GetTypeName());
        }

        public ProcessorElement PatchInstead<TAttribute>()
        {
            return PatchInstead(typeof(TAttribute));
        }
    }
}
