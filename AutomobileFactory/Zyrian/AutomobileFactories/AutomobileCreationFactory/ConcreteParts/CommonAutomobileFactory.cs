using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using CreationConfigurators.Zyrian.Facades;
using CreationConfigurators.Zyrian.Templates;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;
using Entities.Automobiles.AutomobileConstruction.ConcreteParts;

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
        public ICommonAutomobile CreateProduct(ConfigurationTemplate template) =>
            new AutomobileConfigurationFacade<CommonCar>()
                .ProduceAutomobile(template) as ICommonAutomobile;
    }
}
