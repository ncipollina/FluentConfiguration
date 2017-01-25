using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class PipelineSection : XElement
    {
        public PipelineSection(): base("pipelines") { }

        public void AddPipeline(PipelineElement pipelineConfig)
        {
            Add(pipelineConfig);
        }


        public void AddPipeline<TPipeline>(TPipeline pipelineConfig) where TPipeline : PipelineElement, new()
        {
            AddPipeline(pipelineConfig);
        }
    }
}
