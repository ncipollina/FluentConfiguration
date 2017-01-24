using CapTech.FluentConfiguration.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core
{
    public interface IConfigurer
    {
        void AddPipeline(PipelineConfiguration pipelineConfig);
        void AddPipeline<TPipeline>(TPipeline pipelineConfig) where TPipeline : PipelineConfiguration, new();
    }
}
