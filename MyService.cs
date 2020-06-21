using Microsoft.ApplicationInsights;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_V3_sample
{
    public class MyService
    {
        public MyService(ILogger<MyService> logger, TelemetryClient telemetry)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            Telemetry = telemetry ?? throw new ArgumentNullException(nameof(telemetry));
        }

        public void Foo()
        {
            Logger.LogError("Foo");
            Telemetry.TrackEvent("Bar");
        }


        public ILogger<MyService> Logger { get; }
        public TelemetryClient Telemetry { get; }
    }
}
