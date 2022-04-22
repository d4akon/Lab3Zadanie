using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Lab3Task.Interfaces;

namespace Lab3Task.Classes
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;
        private bool disposed;

        public SocketLogger(string host, int port)
        {
            this.clientSocket = new ClientSocket(host, port);
        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }

        public virtual void Log(params string[] messages)
        {
            DateTime time = DateTime.Now;

            try
            {
                string sendedMessage = time.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ";
                foreach (var message in messages) sendedMessage += message + " ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.clientSocket.Dispose();

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}
