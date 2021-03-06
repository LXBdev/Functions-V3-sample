﻿using Microsoft.ApplicationInsights;
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
            Logger.LogInformation("Foo");
            Telemetry.TrackTrace("BarLog", Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Information);
            Telemetry.TrackEvent("BarEvent");
        }


        public ILogger<MyService> Logger { get; }
        public TelemetryClient Telemetry { get; }
    }
}
