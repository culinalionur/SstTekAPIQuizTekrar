using MediatR;
using Nest;
using SstTekAPIQuiz.EmailMediator.GetEmail;
using SstTekAPIQuiz.Linq;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.HandleEmail
{
    public class GetEmailQueryHandler : IRequestHandler<GetEmailQuery, Email>
    {

        public Task<Email> Handle(GetEmailQuery request, CancellationToken cancellationToken)
        {
            Database db = new Database();
            var mail = db.Emails.FirstOrDefault(m=>m.Id == request.Id);
            
            return Task.FromResult(mail);
        }
       
    }

}
