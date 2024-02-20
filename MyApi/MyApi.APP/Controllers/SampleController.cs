using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        // Fields
        private readonly ILogger<SampleController> _logger;
        private static readonly List<int> _samples = new() { 10 };

        // Constructors
        public SampleController(ILogger<SampleController> logger)
        {
            this._logger = logger;
        }

        // Methods
        [HttpGet("/sample")]
        public ContentResult GetSamples()
        // ASP.NET provides many return types under the IActionResult interface. As a rule of thumb, IActionResults deserialize themselves into an HTTP response.
        // ContentResult is good for when you have something to put in the response body.
        {
            string json = JsonSerializer.Serialize(_samples);
            var result = new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = json
            };

            //_logger.LogTrace(); // use trace to record everything, all the time, everywhere.
            _logger.LogInformation($"Sample Value: {_samples[0]}"); ; // useful data, but can still be overwhelming.
            //_logger.LogDebug("logging event from GetSamples");
            //_logger.LogWarning();
            //_logger.LogError();
            //_logger.LogCritical();
            return result;
        }

        [HttpPut("/sample")]
        public ActionResult PutSample([FromBody] int value)
        {
            _samples[location] = value;
            return new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = JsonSerializer.Serialize(_samples)
            };

        }


        // play around with endpoints, play around with returning things with a controller
        [HttpDelete("/sample")]
        // action result was appropriate because i wanted to do an action
        public ActionResult DeleteSample([FromBody] int value)
        {
            _samples.Remove(value);

            // ctrl+k+c comments highlighted
            // ctrl+k+u uncomments highlighted

            //return new ContentResult()
            //{
            //    StatusCode = 200,
            //    ContentType = "application/json",
            //    Content = JsonSerializer.Serialize(_samples)
            //};
        }

        [HttpPost("/sample")]
        // content result means there is something to get back
        public ContentResult PostSample([FromBody] int value)
        {
            _samples.Add(value);

            return new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = JsonSerializer.Serialize(_samples)
            };
        }
    }
}
