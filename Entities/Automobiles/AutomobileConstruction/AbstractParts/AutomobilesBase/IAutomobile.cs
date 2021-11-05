using BaseTypes.MainBaseTypes;
using Entities.AutomobileParts.AbstractParts;
using Entities.Automobiles.AutomobileStrategies.Abstract;
using TrafficPolice;

namespace Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesBase
{
    ///<summary>
    /// Интерфейс автомобиля / образ автомобиля.
    /// <para> Не забыть добавить стратегию передвижения. </para>
    /// </summary>
    /// <remarks>
    ///     <para> Реализует базовый тип сущности <see cref="IBaseType"/>.</para>
    ///     Задаёт контракт общих сведений/компонентов об автомобиле.
    ///     Общие сведения и компоненты представлены в виде свойств и содержатся во всех типах автомобилей.
    /// </remarks>
    public interface IAutomobile : IBaseType, IRegistrable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        
        public int Weight { get; set; }
        public ISpeedRange SpeedRange { get; set; }
        
        public IEngine Engine { get; set; }
        public ITransmission Transmission { get; set; }
        public IWheelsBundle Wheels { get; set; }
    }


}
