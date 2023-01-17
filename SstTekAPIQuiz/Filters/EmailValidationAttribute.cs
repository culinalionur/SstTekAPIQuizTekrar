using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;

namespace SstTekAPIQuiz.Filters
{
    public class EmailValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("email"))
            {
                string email = context.ActionArguments["email"] as string;
                if (!IsValidEmail(email))
                {
                    context.Result = new BadRequestObjectResult("Invalid email address.");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }

    }
}
