using MediatR;

namespace SstTekAPIQuiz.EmailMediator.CommandEmail
{
    public class DeleteEmailCommand : IRequest<DeleteEmailCommandResponse>
    {
       
        public int Id { get; set; }
    }
}
