using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core.Configuration
{
    public class ConfigurationExpression : ConfigurationElement, IConfigurationExpression
    {
        public void AddElement<TElement>() where TElement : ConfigurationElement, new()
        {
            throw new NotImplementedException();
        }
    }
}
