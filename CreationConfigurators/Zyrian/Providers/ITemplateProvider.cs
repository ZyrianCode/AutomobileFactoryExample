using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationConfigurators.Zyrian.Templates;

namespace CreationConfigurators.Zyrian.Providers
{
    public interface ITemplateProvider
    {
        public ConfigurationTemplate? ProvideConfiguration();
    }
}
