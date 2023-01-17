using MediatR;
using SstTekAPIQuiz.EmailMediator.CommandEmail;
using SstTekAPIQuiz.EmailMediator.GetEmail;
using SstTekAPIQuiz.Linq;
using SstTekAPIQuiz.Models;
using SstTekAPIQuiz.Models.Interfaces;

namespace SstTekAPIQuiz.EmailMediator.HandleEmail
{
    public class GetAllEmailQueryHandler : IRequestHandler<GetAllEmailQuery, List<GetAllEmailsQueryResponse>>
    {
        public async Task<List<GetAllEmailsQueryResponse>> Handle(GetAllEmailQuery request, CancellationToken cancellationToken)
        {
            Database db = new Database();
            return db.Emails.Select(x => new GetAllEmailsQueryResponse
            {
                Id = x.Id,
                Body = x.Body,
                To = x.To,
            }).ToList();
        }
    }

}
