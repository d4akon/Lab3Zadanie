using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lab3Task.Interfaces;

namespace Lab3Task.Classes
{
    class SocketLogger : ClientSocket, ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {

        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }

        public void Log (params ) 

        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}
