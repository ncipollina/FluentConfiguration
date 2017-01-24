using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core.Configuration
{
    public class PipelineConfiguration
    {
        public string PipelineName { get; private set; }

        public PipelineConfiguration(string pipelineName)
        {
            PipelineName = pipelineName;
        }
    }
}
