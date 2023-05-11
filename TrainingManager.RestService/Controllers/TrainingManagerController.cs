using Microsoft.AspNetCore.Mvc;
using TrainingManager.RestService.Services;

namespace TrainingManager.RestService.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainingManagerController : ControllerBase
{
    private readonly ITrainingService _trainingService;

    public TrainingManagerController(ITrainingService trainingService)
    {
        _trainingService = trainingService;
    }

    //[HttpGet(Name = "GetWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = DateTime.Now.AddDays(index),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}
}