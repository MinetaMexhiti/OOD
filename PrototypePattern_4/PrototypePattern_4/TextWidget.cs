using System;

namespace PrototypePattern_4
{
    public class WeatherWidget : IWidget
    {
        public void create()
        {
            Console.WriteLine("WeatherWidget: Fetching current weather data");
        }

        public void Configure()
        {
            Console.WriteLine("WeatherWidget: Configuring display for weather data");
        }

        public object clone()
        {
            Console.WriteLine("WeatherWidget: Cloning the weather widget");
            return new WeatherWidget();
        }

       
    }

    public class StocksWidget : IWidget
    {
        public void create()
        {
            Console.WriteLine("StocksWidget: Retrieving real-time stock market information");
        }

        public void Configure()
        {
            Console.WriteLine("StocksWidget: Adjusting settings for stock market display");
        }

        public object clone()
        {
            Console.WriteLine("StocksWidget: Cloning the stocks widget");
            return new StocksWidget();
        }

     
    }
}

