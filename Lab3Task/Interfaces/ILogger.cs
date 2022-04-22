using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task.Interfaces
{
    public interface ILogger : IDisposable
    {
        public void Log(params String[] messages);
    }
}
