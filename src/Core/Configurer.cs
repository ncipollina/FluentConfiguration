using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTech.FluentConfiguration.Core
{
    public class Configurer : IConfigurer
    {
        private static IConfigurer _instance;
        public static IConfigurer Instance
        {
            get
            {
                if (_instance == null)
                    throw new InvalidOperationException("Configurer not initialized.");

                return _instance;
            }

            private set { _instance = value; }
        }

        public static void Initialize(Action<IConfigurationExpression> element)
        {
            Instance = new Configurer();
        }
    }
}
