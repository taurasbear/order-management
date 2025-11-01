using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OrderManagement.Application.Common.Exceptions;
using OrderManagement.Application.Models;
using OrderManagement.Domain.Constants;

namespace OrderManagement.Server.Filters;

public class NotFoundExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is DbEntityNotFoundException notFoundException)
        {
            var errorResponse = new ErrorResponse
            {
                Message = $"Sorry, {notFoundException.EntityType.ToLower()} could not be found.",
                Type = ErrorResponseTypes.NotFound
            };
            context.Result = new NotFoundObjectResult(errorResponse);
            context.ExceptionHandled = true;
        }
    }
}