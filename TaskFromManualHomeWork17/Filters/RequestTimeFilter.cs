using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace TaskFromManualHomeWork17.Filters
{
    public class RequestTimeFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            var elapsedMilliseconds = _stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Request completed in {elapsedMilliseconds} ms");

        }
    }
}
