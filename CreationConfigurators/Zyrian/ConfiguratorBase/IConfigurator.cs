using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace CreationConfigurators.Zyrian.ConfiguratorBase
{
    public interface IConfigurator
    {
        public IBaseType Configure();
    }
}
