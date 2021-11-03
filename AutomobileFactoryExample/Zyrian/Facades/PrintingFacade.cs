using System.Collections.Generic;
using BaseTypes.MainBaseTypes;
using Zyrian.Utils.PrintUtils.Interaction;
using Zyrian.Utils.PrintUtils.Printers;
using Zyrian.Utils.PrintUtils.PrintMethods;

namespace AutomobileFactoryExample.Zyrian.Facades
{
    /// <summary>
    /// Фасад печати.
    /// </summary>
    /// <remarks>
    ///     <para> Реализует <see cref="IPrintUtilsInteractor{TBaseType}"/>. </para>
    ///     <para> Паттерн: Фасад. </para>
    ///     Предоставляет возможности печати компонентов.
    /// </remarks>
    public class PrintingFacade : IPrintUtilsInteractor<IBaseType>
    {
        private readonly List<IBaseType> _objectsToPrint = new();

        public void FillObjectsToPrint(IBaseType objectToPrint) => 
            _objectsToPrint.Add(objectToPrint);

        public void Print(IDataPrinter<IBaseType> dataPrinter, IPrintMethod<IBaseType> printMethod)
        {
            dataPrinter.SetObjectsToPrint(_objectsToPrint);
            dataPrinter.SetPrintMethod(printMethod);
            dataPrinter.PrintData();
        }
    }
}
