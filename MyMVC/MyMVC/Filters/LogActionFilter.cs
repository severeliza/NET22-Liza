using Microsoft.AspNetCore.Mvc.Filters;

namespace MyMVC.Filters
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action has executed.");
        }
    }
}
