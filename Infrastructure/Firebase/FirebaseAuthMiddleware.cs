using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Infrastructure.Firebase
{
    public class FirebaseAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public FirebaseAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Mock check for Authorization header
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            if (string.IsNullOrWhiteSpace(token))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized: Firebase token missing.");
                return;
            }

            // Skip validation for now (mock)
            context.Items["UserId"] = "mock-user-id";
            await _next(context);
        }
    }
}
