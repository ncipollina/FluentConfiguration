using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core
{
    public interface IConfigurationExpression
    {
        void AddElement<TElement>() where TElement : ConfigurationElement, new();
    }
}
