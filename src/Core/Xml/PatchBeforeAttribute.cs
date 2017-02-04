using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class PatchBeforeAttribute : PatchAttribute
    {
        public PatchBeforeAttribute(string beforeType) : base("before", beforeType)
        {
        }
    }
}
