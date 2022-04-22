﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task.Classes
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream, Encoding.UTF8);
        }

        ~FileLogger()
        {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    if (stream != null) this.stream.Dispose();

                this.disposed = true;
            }
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}
