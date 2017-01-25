using System;
using System.Collections.Generic;
using System.Configuration;
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

            //var pipeline = @"<configuration><sitecore><testStuff></testStuff></sitecore></configuration>";

            var registrationClass = ConfigurationManager.AppSettings["FluentConfiguration.Registration"];

            if (!string.IsNullOrEmpty(registrationClass))
            {
                var type = Type.GetType(registrationClass);

                if (type != null)
                {
                    var method = type.GetMethod("RegisterConfigurations");

                    if (method != null)
                    {
                        method.Invoke(null, null);
                        var configPatch = Configurer.Instance.ToString();

                        configPatcher.ApplyPatch(new StringReader(configPatch), "FluentConfiguration");
                    }
                }
            }
        }
    }
}
