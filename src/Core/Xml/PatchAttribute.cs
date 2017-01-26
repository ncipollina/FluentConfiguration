using CapTech.FluentConfiguration.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public abstract class PatchAttribute : XAttribute
    {
        public PatchAttribute(string patch, string type) :
            base(Constants.PATCH + patch, string.Format("processor[@type='{0}']", type))
        { }
    }
}
