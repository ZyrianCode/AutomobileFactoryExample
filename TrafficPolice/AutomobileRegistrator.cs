using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TrafficPolice
{
    public class AutomobileRegistrator
    {
        private string _number;

        public void SetNumberToAdd(string number)
        {
            _number = number;
        }

        public IRegistrable AddNumberToAuto(IRegistrable automobile)
        {
            automobile.Number = _number;
            return automobile;
        }
    }
}
