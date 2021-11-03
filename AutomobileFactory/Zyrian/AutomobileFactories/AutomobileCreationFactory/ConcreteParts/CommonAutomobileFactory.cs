using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using Entities.AbstractParts.AutomobilesTypes;
using Entities.ConcreteParts;

namespace AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.ConcreteParts
{
    /// <summary>
    /// Фабрика обычных автомобилей.
    /// </summary>
    /// <remarks>
    /// Реализует <see cref="ICommonAutomobileFactory"/>.
    ///     <para> Создаёт обычные автомобили. </para>
    ///     <para> Паттерн: Abstract Factory. </para>
    /// </remarks>
    public class CommonAutomobileFactory : ICommonAutomobileFactory
    {
        public ICommonAutomobile CreateProduct() => new CommonCar();
    }
}
