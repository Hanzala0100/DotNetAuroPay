using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Demo
{
    public class CalculateFixture :IDisposable
    {

        public Calculator calculator { get; private set; }
        public CalculateFixture()
        {
            calculator = new Calculator();
        }
        public void Dispose()
        {
            calculator.Dispose();
        }
    }
   
}
