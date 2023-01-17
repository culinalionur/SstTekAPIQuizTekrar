using MediatR;
using SstTekAPIQuiz.EmailMediator.CommandEmail;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.GetEmail
{
    public class GetAllEmailQuery : IRequest<List<GetAllEmailsQueryResponse>>
    {
        public int Id { get; set; }
    }
}
