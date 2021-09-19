using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
//https://stackoverflow.com/questions/51117655/how-to-use-swagger-in-asp-net-webapi-2-0-with-token-based-authentication
//https://www.youtube.com/watch?v=zQRgB6nasUc&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=4&ab_channel=IAmTimCorey
namespace AuthAPI.App_Start
{
  public class AuthTokenFilter : IOperationFilter
  {
    public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
    {
      if(operation.parameters == null)
      {
        operation.parameters = new List<Parameter>();
      }

      operation.parameters.Add(new Parameter
      {
        name = "Auth",
        @in = "header",
        description = "token",
        required = false,
        type = "string",
        @default = "bearer P91bAquzny1MkfNxELhNynDnV4Ut_W3mb-7hyxJqmafbJCzqM38R7Nt7IEPJVc4VGMIaznUwtP6JTc_0f0Pvnxz30I716kAzys6SAMpTzheARvIow1bXFCtlWIOT_oHpgQdvr6LtJSk0m7BuaJg3ALjMfBnwY2pCm60aVXu4hw-e0V9-7NtT8NoXb4PaVZcvlQr5SD-Kyy4hizNzdt6uILQXjN7v7jB5jLf4xDo3XWIjMkuPAoWyKRIluaUsd88PSw034KG1eQfFuLaqjLSmP84ThD275PsromxelEplxYz7vyKNbLulG0Mt8P-Q5FDcUARbKC4GFc_HBLqwPQ9pS73PAZKIOzf7XuIyhoT_epTVrFUUgVvAyRh-GL4AStT5kSM3M_8VUQMHmwRYhWYSpUDF7nOrm1LsABiwMKZvVVEhaEWxEYr1z9OX0OPOuaVXjej-CFl9xJeFTrdkcDSWccArtrUOvXnht7MStHyPIXx3tR5dCJGWlWj5bBd8OiTC"
      });
    }
  }
}
