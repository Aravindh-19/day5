using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class customer : IDisposable
    {
        private StringReader _reader;
        private bool disposed = false;
        public customer(string value)
        {
            this._reader = new StringReader(value);
        }

        protected virtual void dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_reader != null)
                    {
                        this._reader.Dispose();
                    }
                }
            }
            disposed = true;
        }
        public void dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public class sample
    {
        public static void Main()
        {
            customer c = new customer("Sample");
            Console.ReadLine();
        }
    }
}
