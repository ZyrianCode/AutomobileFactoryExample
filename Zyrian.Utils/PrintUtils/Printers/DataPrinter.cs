using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyrian.Utils.PrintUtils.PrintMethods;

namespace Zyrian.Utils.PrintUtils.Printers
{
    /// <summary>
    /// Класс печатающий данные.
    /// </summary>
    /// <remarks> Реализует <see cref="IDataPrinter{TBaseType}"/>.
    ///     <para> Печатает данные. </para>
    /// </remarks>
    /// 
    /// <typeparam name="TBaseType"> Тип базового типа. </typeparam>
    public class DataPrinter<TBaseType> : IDataPrinter<TBaseType>
    {
        private List<TBaseType> _objectsToPrint;
        private IPrintMethod<TBaseType> _printMethod;

        public void SetObjectsToPrint(List<TBaseType> objectsToPrint) => 
            _objectsToPrint = objectsToPrint ?? throw new ArgumentNullException(nameof(objectsToPrint));

        public void SetPrintMethod(IPrintMethod<TBaseType> printMethod) => 
            _printMethod = printMethod ?? throw new ArgumentNullException(nameof(printMethod));

        public void PrintData() => 
            _printMethod.Print(_objectsToPrint);
    }
}
