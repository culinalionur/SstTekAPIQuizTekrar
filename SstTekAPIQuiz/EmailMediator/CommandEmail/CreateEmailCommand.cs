using MediatR;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.CreateEmail
{
    public class CreateEmailCommand : IRequest<Email>
    {
        public string Body { get; set; }
        public string To { get; set; }

    }
}
