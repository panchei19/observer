﻿using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureReporter reporter = new TemperatureReporter();
            reporter.Subscribe(monitor);
            monitor.GetTemperature();
        }
    }
}
