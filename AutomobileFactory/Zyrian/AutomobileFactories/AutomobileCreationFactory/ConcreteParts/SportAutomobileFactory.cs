using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using CreationConfigurators.Zyrian.Facades;
using CreationConfigurators.Zyrian.Templates;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;
using Entities.Automobiles.AutomobileConstruction.ConcreteParts;

namespace AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.ConcreteParts
{
    /// <summary>
    /// Фабрика необычных автомобилей.
    /// </summary>
    /// <remarks> Реализует <see cref="ISportAutomobileFactory"/>.
    ///     <para> Создаёт необычные автомобили. </para>
    ///     <para> Паттерн: Abstract Factory. </para>
    /// </remarks>
    public class SportAutomobileFactory : ISportAutomobileFactory
    {
        public ISportAutomobile CreateProduct(ConfigurationTemplate template) =>
            new AutomobileConfigurationFacade<SportCar>()
                .ProduceAutomobile(template) as ISportAutomobile;
    }
}
