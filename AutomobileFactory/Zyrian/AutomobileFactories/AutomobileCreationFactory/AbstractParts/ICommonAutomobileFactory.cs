using System.Runtime.CompilerServices;
using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.MainAbstractParts;

using BaseTypes.MainBaseTypes;
using Entities.AbstractParts.AutomobilesTypes;

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
        /// Создаёт продукт обычного автомобиля.
        /// </summary>
        /// <returns>Экземпляр <see cref="ICommonAutomobile"/>. </returns>
        public ICommonAutomobile CreateProduct();
    }
}
