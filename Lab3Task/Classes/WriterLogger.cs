using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using Lab3Task.Interfaces;

namespace Lab3Task.Classes
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            string sendedMessage = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ";
            foreach (var message in messages) sendedMessage += message + " ";

            writer.WriteLine(sendedMessage);
            writer.Flush();
        }

        public abstract void Dispose();
    }
}
