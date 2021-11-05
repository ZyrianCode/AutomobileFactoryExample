using System.Runtime.CompilerServices;
using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.MainAbstractParts;

using BaseTypes.MainBaseTypes;
using CreationConfigurators.Zyrian.Templates;
using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;

namespace AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts
{
    /// <summary>
    /// Интерфейс фабрики по создагию обычных автоомобилей.
    /// </summary>
    /// <remarks>
    ///     Реализует <see cref="IAutomobileCreationFactory"/>. 
    ///     <para> Паттерн: Abstract Factory. </para>
    /// </remarks>
    public interface ICommonAutomobileFactory : IAutomobileCreationFactory, IBaseType
    {
        /// <summary>
        /// Создаёт продукт обычного автомобиля по шаблону.
        /// </summary>
        /// <param name="template"> шаблон для создания автомобиля </param>
        /// <returns> Экземпляр <see cref="ICommonAutomobile"/>. </returns>
        public ICommonAutomobile CreateProduct(ConfigurationTemplate template);
    }
}
