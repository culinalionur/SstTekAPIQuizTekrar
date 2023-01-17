namespace SstTekAPIQuiz.Models.Interfaces
{
    public interface IRepository<T> 
    {
        Task<List<T>> GetAllAsync();

    }
}
