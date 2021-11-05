using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;
using Entities.Automobiles.AutomobileStrategies.Abstract;

namespace Entities.Automobiles.AutomobileConstruction.ConcreteParts
{
    public class SportCar : ISportAutomobile
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public int Weight { get; set; }
        public ISpeedRange SpeedRange { get; set; }
        public IEngine Engine { get; set; }
        public ITransmission Transmission { get; set; }
        public IWheelsBundle Wheels { get; set; }

        public override string ToString()
        {
            return $"Бренд автомобиля: {Brand}, Модель автомобиля: {Model}, Гос.Номер: {Number}." +
                   $"Максимальная скорость: {SpeedRange.MaxSpeed}. " +
                   $"Двигатель: {Engine}. " +
                   $"Трансмиссия: {Transmission}. " +
                   $"Колёса: {Wheels} ";
        }
    }
}
