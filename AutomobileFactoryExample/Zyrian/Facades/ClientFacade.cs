using System.Collections.Generic;
using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using BaseTypes.MainBaseTypes;
using CreationConfigurators.Zyrian.Facades;

using Entities.Automobiles.AutomobileConstruction.AbstractParts.AutomobilesTypes;
using Zyrian.Utils.PrintUtils.Printers;
using Zyrian.Utils.PrintUtils.PrintMethods;

namespace AutomobileFactoryExample.Zyrian.Facades
{
    /// <summary>
    /// Фасад для клиента.
    /// </summary>
    /// <remarks>
    ///     Паттерн: Фасад.
    ///     <para> Упрощает процесс создания автомобилей в фабрике. </para>
    /// </remarks>
    /// 
    public class ClientFacade
    {
        private ICommonAutomobile _commonAutomobile;
        private ISportAutomobile _uncommonAutomobile;

        private readonly PrintingFacade _printFacade = new();
        private List<IBaseType> _objectsToPrint = new();

        /// <summary>
        /// Производит обычные продукты.
        /// </summary>
        /// <param name="automobileFactory"> фабрика производства обычных продуктов. </param>
        public void ProduceCommonProducts(ICommonAutomobileFactory automobileFactory)
        {
            _commonAutomobile = automobileFactory.CreateProduct(
                new UserFacade()
                    .SetCommonAutomobileTemplate()
                    .ProvideConfiguration()
                );
        }

        /// <summary>
        /// Производит необычные продукты.
        /// </summary>
        /// <param name="automobileFactory"> фабрика производства необычных продуктов. </param>
        public void ProduceUncommonProducts(ISportAutomobileFactory automobileFactory)
        {
            _uncommonAutomobile = automobileFactory.CreateProduct(
                new UserFacade()
                    .SetSportCarTemplate()
                    .ProvideConfiguration()
                );
        }

        /// <summary>
        /// Печатает продукты фабрики.
        /// </summary>
        public void Print()
        {
            _printFacade.FillObjectsToPrint(_commonAutomobile);
            _printFacade.FillObjectsToPrint(_uncommonAutomobile);
            _printFacade.Print(new DataPrinter<IBaseType>(), new ConsolePrintMethod<IBaseType>());
        }
    }
}
