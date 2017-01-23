using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapTech.FluentConfiguration.Core.Configuration
{
    public class ConfigReader : Sitecore.Configuration.ConfigReader
    {
        protected override void LoadAutoIncludeFiles(XmlNode element)
        {
            base.LoadAutoIncludeFiles(element);
            var configPatcher = GetConfigPatcher(element);

            var pipeline = @"<configuration><sitecore><testStuff></testStuff></sitecore></configuration>";

            pipeline = new PipelineElement().OutputXml();

            configPatcher.ApplyPatch(new StringReader(pipeline), "FluentConfiguration");
        }
    }
}
