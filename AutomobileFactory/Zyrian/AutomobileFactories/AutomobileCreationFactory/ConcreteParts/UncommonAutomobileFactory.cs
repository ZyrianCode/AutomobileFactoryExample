using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using Entities.AbstractParts.AutomobilesTypes;
using Entities.ConcreteParts;

namespace AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.ConcreteParts
{
    /// <summary>
    /// Фабрика необычных автомобилей.
    /// </summary>
    /// <remarks> Реализует <see cref="IUncommonAutomobileFactory"/>.
    ///     <para> Создаёт необычные автомобили. </para>
    ///     <para> Паттерн: Abstract Factory. </para>
    /// </remarks>
    public class UncommonAutomobileFactory : IUncommonAutomobileFactory
    {
        public IUncommonAutomobile CreateProduct() => new UncommonCar();
    }
}
