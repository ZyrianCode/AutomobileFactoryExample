using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;
using CreationConfigurators.Zyrian.ConfiguratorBase;
using Entities.AutomobileParts.AbstractParts;

namespace CreationConfigurators.Zyrian.AdditionalConfigurators
{
    public class EngineConfigurator
    {
        private IEngine _engine;

        public EngineConfigurator SetEngineType(IEngine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            return this;
        }

        public EngineConfigurator SetName(string engineName)
        {
            _engine.Name = engineName;
            return this;
        }

        public EngineConfigurator SetCountOfCylinders(int cylindersCount)
        {
            _engine.CountOfCylinders = cylindersCount;
            return this;
        }

        public EngineConfigurator SetType(string type)
        {
            _engine.Type = type;
            return this;
        }

        public IEngine Configure() => _engine;
    }
}
