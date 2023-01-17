using MediatR;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.GetEmail
{
    public class GetEmailQuery : IRequest<Email>
    {
        public int Id { get; set; }
    }
}
