using SstTekAPIQuiz.Models;

namespace SstTekAPIQuiz.Linq
{
    public class GroupedEmail
    {
        public string EmailGroupName { get; set; }
        public List<Email>  Emails { get; set; }
    }
}
