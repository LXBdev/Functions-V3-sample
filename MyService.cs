using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_V3_sample
{
    public class MyService
    {
        public MyService(ILogger<MyService> logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Foo()
        {
            Logger.LogError("Foo!");
        }


        public ILogger<MyService> Logger { get; }
    }
}
