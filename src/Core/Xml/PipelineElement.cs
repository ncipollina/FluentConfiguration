using CapTech.FluentConfiguration.Core.Helpers;
using CapTech.FluentConfiguration.Core.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class PipelineElement : XElement
    {

        public PipelineElement(string pipelineName) : base(pipelineName)
        {
        }

        public ProcessorElement AddProcessor(string typeName)
        {
            var pipeline = new ProcessorElement(typeName);
            Add(pipeline);
            return pipeline;
        }

        public ProcessorElement AddProcessor(Type type)
        {
            return AddProcessor(type.GetTypeName());
        }

        public ProcessorElement AddProcessor<TElement>()
        {
            return AddProcessor(typeof(TElement));
        }
    }
}
