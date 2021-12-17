using NSE.WebApp.MVC.Extensions;
using System.Net;
using System.Net.Http;

namespace NSE.WebApp.MVC.Services
{
    public abstract class Service
    {
        protected bool TratarErrosResponse(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                case HttpStatusCode.Forbidden:
                case HttpStatusCode.NotFound:
                case HttpStatusCode.InternalServerError:
                    throw new CustomHttpRequestException(response.StatusCode);
                case HttpStatusCode.BadRequest:
                    return false;
            }

            response.EnsureSuccessStatusCode();

            return true;
        }
    }
}
