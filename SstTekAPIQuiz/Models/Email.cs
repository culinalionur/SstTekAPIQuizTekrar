using SstTekAPIQuiz.Models.Interfaces;

namespace SstTekAPIQuiz.Models
{
    public class Email : IEmailService
    {

        public int Id { get; set; }
        public string Body { get; set; }
        public string To { get; set; }
       

        public void SendMail(string email,string to)
        {
            Body = email;
            To = to;
            
        }
    }
}
