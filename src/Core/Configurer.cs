using CapTech.FluentConfiguration.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core
{
    public class Configurer : IConfigurer
    {
        private static volatile IConfigurer _instance;
        private static object syncRoot = new object();

        private readonly IList<PipelineConfiguration> _pipelineConfigs = new List<PipelineConfiguration>();

        private Configurer() { }
        public static IConfigurer Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Configurer();
                        }
                    }
                }
                return _instance;
            }

            private set { _instance = value; }
        }


        public void AddPipeline(PipelineConfiguration pipelineConfig)
        {
            _pipelineConfigs.Add(pipelineConfig);
        }


        public void AddPipeline<TPipeline>(TPipeline pipelineConfig) where TPipeline : PipelineConfiguration, new()
        {
            AddPipeline(pipelineConfig);
        }
    }
}
