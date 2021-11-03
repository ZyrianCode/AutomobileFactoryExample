using System.Collections.Generic;
using System.ComponentModel;
using Zyrian.Utils.PrintUtils.Printers;
using Zyrian.Utils.PrintUtils.PrintMethods;

namespace Zyrian.Utils.PrintUtils.Interaction
{
    /// <summary>
    /// Интерфейс взаимодействия с печатающей утилитой.
    /// </summary>
    /// <remarks> Предоставляет интерфейс взаимодействия для заполнения объектов печати. </remarks>
    /// <typeparam name="TBaseType"> Базовый тип приложения. </typeparam>
    public interface IPrintUtilsInteractor<TBaseType>
    {
        /// <summary>
        /// Предоставляет возможность заполнения объектов для печати.
        /// </summary>
        /// <param name="objectToPrint"> экземпляр базового типа приложения <typeparamref name="TBaseType"/>.
        ///     Сюда будет подставлен экземпляр типа, реализующий базовый интерфейс. </param>
        public void FillObjectsToPrint(TBaseType objectToPrint);

        /// <summary>
        /// Предоставляет возможность печатать объекты определённым печатающим классом, с различными способами печати.
        /// </summary>
        /// <param name="dataPrinter"> Экземпляр <see cref="IDataPrinter{TBaseType}"/>.
        ///     Сюда будет подставлен конкретный экземпляр печатающего класса. </param>
        /// <param name="printMethod"> Экземпляр <see cref="IPrintMethod{TBaseType}"/>.
        ///     Сюда будет подставлен конкретный экземпляр класса, представляющий собой способ печати. </param>
        public void Print(IDataPrinter<TBaseType> dataPrinter, IPrintMethod<TBaseType> printMethod);
    }
}