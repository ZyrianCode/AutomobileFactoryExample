using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace Entities.Automobiles.AutomobileStrategies.ConcreteVariations
{
    public class MiddleSpeedRange : ISpeedRange
    {
        public int MaxSpeed { get; set; }
    }
}
