using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Demo
{
    public class Calculator :IDisposable
    {
        private bool disposed = false;


        protected virtual void  Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free managed resources here if any
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtract(int x, int y)
        {
            //throw new NotImplementedException("This method is not implemented yet.");
            return x - y;
        }

        public int div(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return x / y;
        }

        public string printHiMessage(string name)
        {
            return $"Hi {name}";
        }
    }
}
