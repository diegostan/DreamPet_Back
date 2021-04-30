namespace DPBack.Domain.Repositories.Interfaces
{
    public interface IRepository
    {
        void Create(object obj);
        void Update(object obj);
        void Delete(object obj);
    }
}