namespace SstTekAPIQuiz.Models.Interfaces
{
    public interface IEmailService
    {
        public string  SendMail(string email, string to)
        {
            if (email==null)
            {
                return "This mail does not contains a body";
            }
            return SendMail(email, to);
        }
    }
}
