using System.Collections.Generic;
using NonaWalt.Web.Models;

namespace NonaWalt.Web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
