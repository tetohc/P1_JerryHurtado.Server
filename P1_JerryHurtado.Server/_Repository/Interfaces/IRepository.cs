namespace P1_JerryHurtado.Server._Repository.Interfaces
{
    public interface IRepository<T>
    {
        bool Add(T model);

        T GetById(int id);

        IEnumerable<T> GetAll();

        bool IsEmpty();

        int GetNewIdValue();
    }
}