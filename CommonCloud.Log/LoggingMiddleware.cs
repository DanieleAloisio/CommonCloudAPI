using CommonCloud.Log.Dto;
using CommonCloud.Mediator.Commands;
using CommonCloud.Repository.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text;

namespace CommonCloud.Log
{
    /// <summary>
    /// Middleware per log chiamate http
    /// </summary>
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IMediator mediator)
        {
            try
            {
                await _next(context);
            }
            catch (ItemNotFoundException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            catch (Exception)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            finally
            {
                var request = FormatRequest(context.Request);
                var response = context.Response.StatusCode.ToString();

                var model = new InsertLogCommand(request, response);
                await mediator.Send(model);
            }
           
        }

        private string FormatRequest(HttpRequest request)
        {
            return $"{request.Path} {request.QueryString}";
        }

        private string FormatResponse(HttpResponse response)
        {
            return $"{response.StatusCode}: {response.Body}";
        }
    }
}

