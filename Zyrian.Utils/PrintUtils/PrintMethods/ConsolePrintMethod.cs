using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes.MainBaseTypes;

namespace Zyrian.Utils.PrintUtils.PrintMethods
{
    /// <summary>
    /// Консольный способ печати данных.
    /// </summary>
    /// <remarks> Реализует <see cref="IPrintMethod{TBaseType}"/>. </remarks>
    /// <remarks> Осуществляет печать данных через консоль. </remarks>
    /// <typeparam name="TBaseType"> Базовый тип приложения. </typeparam>
    public class ConsolePrintMethod<TBaseType> : IPrintMethod<TBaseType>
    {
        public void Print(List<TBaseType> objectsToPrint)
        {
            foreach (var objectToPrint in objectsToPrint)
            {
                Console.WriteLine(objectToPrint.ToString());
            }
        }
    }
}
