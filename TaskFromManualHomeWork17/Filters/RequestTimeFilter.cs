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

            context.HttpContext.Response.OnStarting(() =>
            {
                _stopwatch.Stop();
                var elapsedMilliseconds = _stopwatch.ElapsedMilliseconds;
                context.HttpContext.Response.Headers["X-Response-Time-FromFilter-ms"] = elapsedMilliseconds.ToString();
                Console.WriteLine(elapsedMilliseconds.ToString());
                return Task.CompletedTask;
            });
        }
    }
}
