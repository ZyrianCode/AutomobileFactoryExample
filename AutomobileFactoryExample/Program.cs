using System;
using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.AbstractParts;
using AutomobileFactory.Zyrian.AutomobileFactories.AutomobileCreationFactory.ConcreteParts;
using AutomobileFactoryExample.Zyrian.Facades;

namespace AutomobileFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommonAutomobileFactory commonAutomobileFactory =
                new CommonAutomobileFactory();

            ISportAutomobileFactory uncommonAutomobileFactory =
                new SportAutomobileFactory();

            ClientFacade clientFacade = new();
            clientFacade.ProduceCommonProducts(commonAutomobileFactory);
            clientFacade.ProduceUncommonProducts(uncommonAutomobileFactory);
            clientFacade.Print();

            Console.WriteLine("Hello from TestProject!");
        }
    }
}
