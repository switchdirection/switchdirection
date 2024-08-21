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
            await _next(context);
            stopwatch.Stop();
            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            await Console.Out.WriteLineAsync(elapsedMilliseconds.ToString());
        }
    }
}
