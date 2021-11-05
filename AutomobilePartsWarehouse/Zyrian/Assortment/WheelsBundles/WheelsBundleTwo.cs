using AutomobilePartsWarehouse.Zyrian.Assortment.Wheels;
using Entities.AutomobileParts.AbstractParts;

namespace AutomobilePartsWarehouse.Zyrian.Assortment.WheelsBundles
{
    public class WheelsBundleTwo : IWheelsBundle
    {
        public string Name { get; set; }
        public IWheel ForwardLeftWheel { get; set; } = new WheelsTypeTwo();
        public IWheel ForwardRightWheel { get; set; } = new WheelsTypeTwo();
        public IWheel BackwardLeftWheel { get; set; } = new WheelsTypeTwo();
        public IWheel BackwardRightWheel { get; set; } = new WheelsTypeTwo();

        public override string ToString()
        {
            return $"Наименование: {Name}. ";
        }
    }
}
