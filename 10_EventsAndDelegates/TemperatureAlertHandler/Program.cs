﻿namespace TemperatureAlertHandler
{
    // public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }

    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // public event EventHandler<TemperatureChangeHandler> TemperatureChange;

                     // Type of a delegate
        // public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set 
            {
                
                if (_temperature != value)
                {
                    _temperature = value;
                    // Raise event!
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Every subscriber is informed
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature}, sender is {sender} ");
        }
    }

    // subscriber
    public class TemperatureCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Cooling Alert: temperature is {e.Temperature}, sender is {sender} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TemperatureCoolingAlert temperatureCoolingAlert = new TemperatureCoolingAlert();

            // adding an event            // subscriber  
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += temperatureCoolingAlert.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
