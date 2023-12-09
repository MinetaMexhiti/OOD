using PrototypePattern_4;
using System;

class Program
{
    static void Main()
    {
        var prototypeManager = new PrototypeManager();

        prototypeManager["WeatherWidget"] = new WeatherWidget();
        prototypeManager["StocksWidget"] = new StocksWidget();

        var weatherWidget1 = prototypeManager["WeatherWidget"];
        var weatherWidget2 = prototypeManager.ContainsKey("WeatherWidget") ? prototypeManager["WeatherWidget"].clone() as IWidget : null;

        var stocksWidget1 = prototypeManager["StocksWidget"];
        var stocksWidget2 = prototypeManager.ContainsKey("StocksWidget") ? prototypeManager["StocksWidget"].clone() as IWidget : null;

        weatherWidget1?.create();
        weatherWidget1?.Configure();

        weatherWidget2?.create();
        weatherWidget2?.Configure();

        stocksWidget1?.create();
        stocksWidget1?.Configure();

        stocksWidget2?.create();
        stocksWidget2?.Configure();
    }
}
