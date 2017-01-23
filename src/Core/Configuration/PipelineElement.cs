using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Configuration
{
    public class PipelineElement : ConfigurationElement
    {
        public string OutputXml()
        {
            var element = new XElement("configuration",
                new XElement("sitecore",
                new XElement("pipelins",
                new XElement("testPipeline",
                new XElement("processor", new XAttribute("type", "Va.Abc.Framework.Pipelines.Response.GetPageItem.GetFromBucket, Va.Abc.Framework"))
                )
                )
                )
                );

            return element.ToString();
        }
    }
}
