using CapTech.FluentConfiguration.Core.Configuration;
using CapTech.FluentConfiguration.Core.Helpers;
using CapTech.FluentConfiguration.Core.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core
{
    public class Configurer : XElement
    {
        private static volatile Configurer _instance;
        private static object syncRoot = new object();

        private readonly XElement _sitecoreElement = new XElement("sitecore");

        private Configurer() : base("configuration")
        {
            Add(new XAttribute(XNamespace.Xmlns + "patch", Constants.PATCH),
                _sitecoreElement);
        }
        public static Configurer Instance
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

        private PipelineSection _pipelines;

        public PipelineSection Pipelines
        {
            get
            {
                if (_pipelines == null)
                {
                    _pipelines = new PipelineSection();
                    _sitecoreElement.Add(_pipelines);
                }
                return _pipelines;
            }
        }
    }
}
