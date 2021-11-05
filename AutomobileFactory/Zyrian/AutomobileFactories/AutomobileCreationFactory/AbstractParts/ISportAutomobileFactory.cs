using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.MainAbstractParts;
using BaseTypes.MainBaseTypes;
using CreationConfigurators.Zyrian.Templates;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;

namespace AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts
{
    /// <summary>
    /// Интерфейс фабрики по создагию необычных автоомобилей.
    /// </summary>
    /// <remarks>
    ///     Реализует <see cref="IAutomobileCreationFactory"/>.
    ///     <para> Паттерн: Abstract Factory. </para>
    /// </remarks>
    /// 
    public interface ISportAutomobileFactory : IAutomobileCreationFactory, IBaseType
    {
        /// <summary>
        /// Создаёт продукт необычного автомобиля.
        /// </summary>
        /// <param name="template"> шаблон для создания автомобиля </param>
        /// <returns> Экземпляр <see cref="ISportAutomobile"/>. </returns>
        public ISportAutomobile CreateProduct(ConfigurationTemplate template);
    }
}
