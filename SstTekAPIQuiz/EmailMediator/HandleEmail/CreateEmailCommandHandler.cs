using MediatR;
using SstTekAPIQuiz.EmailMediator.CreateEmail;
using SstTekAPIQuiz.Linq;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.HandleEmail
{
    public class CreateEmailCommandHandler : IRequestHandler<CreateEmailCommand, Email>
    {
        public Task<Email> Handle(CreateEmailCommand request, CancellationToken cancellationToken)
        {
            Database db = new Database();
            var maxId = db.Emails.MaxBy(m => m.Id)!.Id;
            var newId = maxId + 1;
            Email newMail = new Email
            {
                Id = newId,
                Body = request.Body,
                To = request.To,
            };
            db.Emails.Add(newMail);
            return Task.FromResult<Email>(newMail);
        }
    }
}
