namespace TaskFromManualHomeWork17.Middlewere
{
    public class MiddlewereExceptions
    {
        private readonly RequestDelegate _next;

        public MiddlewereExceptions(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка " + ex.Message);
                context.Response.Redirect("/");
            }
        }
    }
}
