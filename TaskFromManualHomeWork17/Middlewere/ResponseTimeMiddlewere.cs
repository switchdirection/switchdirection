using System.Diagnostics;

namespace TaskFromManualHomeWork17.Middlewere
{
    public class ResponseTimeMiddlewere
    {
        private readonly RequestDelegate _next;

        public ResponseTimeMiddlewere(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            context.Response.OnStarting(() =>
            {
                stopwatch.Stop();
                var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                context.Response.Headers["X-Response-Time-ms"] = elapsedMilliseconds.ToString();

                return Task.CompletedTask;
            });
            await _next(context);
        }
    }
}
