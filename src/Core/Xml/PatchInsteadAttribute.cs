﻿using CapTech.FluentConfiguration.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapTech.FluentConfiguration.Core.Xml
{
    public class PatchInsteadAttribute : PatchAttribute
    {
        public PatchInsteadAttribute(string insteadType) :
            base("instead", insteadType)
        { }
    }
}
