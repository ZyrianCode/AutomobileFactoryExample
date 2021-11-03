using System.Collections.Generic;
using Zyrian.Utils.PrintUtils.PrintMethods;

namespace Zyrian.Utils.PrintUtils.Printers
{
    /// <summary>
    /// Интерфейс классов, печатающих данные.
    /// </summary>
    /// <remarks> Задаёт контракт для классов, печатающих данные. </remarks>
    /// <typeparam name="TBaseType"> Базовый тип приложения. </typeparam>
    public interface IDataPrinter<TBaseType>
    {
        /// <summary>
        /// Устанавливает объекты для печати <see cref="List{T}"/>.
        /// </summary>
        /// <param name="objectsToPrint"> Экземпляр <see cref="List{T}"/>.
        ///     Сюда будет подставлен конкретный экземпляр списка объектов для печати.
        /// </param>
        public void SetObjectsToPrint(List<TBaseType> objectsToPrint);

        /// <summary>
        /// Устанавливает способ печати <see cref="IPrintMethod{TBaseType}"/>.
        /// </summary>
        /// <param name="printMethod"> Экземпляр <see cref="IPrintMethod{TBaseType}"/>.
        ///     Сюда будет подставлен конкретный экземпляр класса, представляющего собой способ печати.
        /// </param>
        public void SetPrintMethod(IPrintMethod<TBaseType> printMethod);

        /// <summary>
        /// Печатает данные.
        /// </summary>
        public void PrintData();
    }
}
