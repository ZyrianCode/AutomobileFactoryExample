using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.MainAbstractParts;
using BaseTypes.MainBaseTypes;
using Entities.AbstractParts.AutomobilesTypes;

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
    public interface IUncommonAutomobileFactory : IAutomobileCreationFactory, IBaseType
    {
        /// <summary>
        /// Создаёт продукт необычного автомобиля.
        /// </summary>
        /// <returns> Экземпляр <see cref="IUncommonAutomobile"/>. </returns>
        public IUncommonAutomobile CreateProduct();
    }
}
