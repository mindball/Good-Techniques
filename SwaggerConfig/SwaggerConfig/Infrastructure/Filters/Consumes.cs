﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net.Mime;

namespace SwaggerConfig.Infrastructure.Filters
{
    internal class Consumes : IOperationFilter
    {        
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            foreach (var key in operation.Responses.Keys)
            {
                FilterMediaTypes(operation.Responses[key].Content);
            }

            if (operation.RequestBody?.Content != null)
            {
                FilterMediaTypes(operation.RequestBody.Content);
            }
        }

        private static void FilterMediaTypes(IDictionary<string, OpenApiMediaType> apiMediaTypes)
        {
            if (apiMediaTypes.TryGetValue(MediaTypeNames.Application.Json, out OpenApiMediaType applicationJson))
            {
                apiMediaTypes.Clear();
                apiMediaTypes.Add(MediaTypeNames.Application.Json, applicationJson);
                apiMediaTypes.Add(MediaTypeNames.Application.Xml, applicationJson);
            }
        }
    }
}
