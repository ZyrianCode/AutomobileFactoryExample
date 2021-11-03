using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace Zyrian.Utils.PrintUtils.PrintMethods
{
    /// <summary>
    /// Интерфейс классов, представляющих способ печати.
    /// </summary>
    /// <remarks> Задаёт контракт классам-способам печати. </remarks>
    /// <typeparam name="TBaseType"> Базовый тип приложения. </typeparam>
    public interface IPrintMethod<TBaseType>
    {
        /// <summary>
        /// Печатает данные.
        /// </summary>
        /// <param name="objectsToPrint"> Экземпляр <see cref="List{T}"/>.
        ///     Сюда будет подставлен конкретный экземпляр списка данных для печати.
        /// </param>
        public void Print(List<TBaseType> objectsToPrint);
    }
}
