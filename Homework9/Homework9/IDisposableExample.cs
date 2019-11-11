using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;

namespace Homework9
{
    public class IDisposableExample:IDisposable
    {
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        bool disposed = false;
        private StreamWriter SWriter;
        public void LogWriter(string logFile)
        {
            SWriter = new StreamWriter(logFile, true);
        }
        public void Write()
        {
            SWriter.WriteLine("Starting logging at {0}", DateTime.Now);
        }
        public void WriteLine(string message)
        {
            SWriter.WriteLine(message);
        }
          
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose called");
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {

                SWriter.Dispose();
             //   handle.Dispose();
            }


            disposed = true;
        }

    }
}
