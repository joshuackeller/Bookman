using System;
using Microsoft.AspNetCore.Http;

namespace Bookman.Controllers.Infrastructure
{
    public static class EmptyClass
    {
       public static string PathAndQuery(this HttpRequest request) 
        {
            return request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
        }
    }
}
