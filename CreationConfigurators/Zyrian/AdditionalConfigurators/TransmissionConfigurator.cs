using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.AutomobileParts.AbstractParts;

namespace CreationConfigurators.Zyrian.AdditionalConfigurators
{
    public class TransmissionConfigurator
    {
        private ITransmission _transmission;

        public TransmissionConfigurator SetTransmissionType(ITransmission transmissionType)
        {
            _transmission = transmissionType ?? throw new ArgumentNullException(nameof(transmissionType));
            return this;
        }

        public TransmissionConfigurator SetName(string name)
        {
            _transmission.Name = name;
            return this;
        }

        public ITransmission Configure() => _transmission;
    }
}
