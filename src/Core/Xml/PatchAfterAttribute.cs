using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class PatchAfterAttribute : PatchAttribute
    {
        public PatchAfterAttribute(string afterType) : base("after", afterType)
        {
        }
    }
}
