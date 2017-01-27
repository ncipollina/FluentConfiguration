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

        public ProcessorElement InsteadOf(string insteadType)
        {
            Add(new PatchInsteadAttribute(insteadType));
            return this;
        }

        public ProcessorElement InsteadOf(Type insteadType)
        {
            return InsteadOf(insteadType.GetTypeName());
        }

        public ProcessorElement InsteadOf<TAttribute>()
        {
            return InsteadOf(typeof(TAttribute));
        }
    }
}
