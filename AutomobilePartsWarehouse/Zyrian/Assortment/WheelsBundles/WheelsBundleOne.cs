using AutomobilePartsWarehouse.Zyrian.Assortment.Wheels;
using Entities.AutomobileParts.AbstractParts;

namespace AutomobilePartsWarehouse.Zyrian.Assortment.WheelsBundles
{
    public class WheelsBundleOne : IWheelsBundle
    {
        public string Name { get; set; }
        public IWheel ForwardLeftWheel { get; set; } = new WheelsTypeOne();
        public IWheel ForwardRightWheel { get; set; } = new WheelsTypeOne();
        public IWheel BackwardLeftWheel { get; set; } = new WheelsTypeOne();
        public IWheel BackwardRightWheel { get; set; } = new WheelsTypeOne();

        public override string ToString()
        {
            return $"Наименование: {Name}. ";
        }
    }
}
