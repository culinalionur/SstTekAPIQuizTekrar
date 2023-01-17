using MediatR;
using Nest;
using SstTekAPIQuiz.EmailMediator.CommandEmail;
using SstTekAPIQuiz.Linq;
using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.EmailMediator.HandleEmail
{
    public class DeleteEmailCommandHandler : IRequestHandler<DeleteEmailCommand, DeleteEmailCommandResponse>
    {
        public async Task<DeleteEmailCommandResponse> Handle(DeleteEmailCommand request, CancellationToken cancellationToken)
        {
            Database db = new Database();
            var deleteMail = db.Emails.FirstOrDefault(x=>x.Id == request.Id);
            db.Emails.Remove(deleteMail);
            return new DeleteEmailCommandResponse
            {
                IsSuccess = true,
            };
            
        }
    }
}
