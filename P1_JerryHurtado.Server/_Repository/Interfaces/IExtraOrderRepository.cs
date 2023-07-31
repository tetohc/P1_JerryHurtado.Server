namespace P1_JerryHurtado.Server._Repository.Interfaces
{
    public interface IExtraOrderRepository<T>
    {
        bool Add(T model);

        T GetById(int orderId, int dishId, int extraId);

        IEnumerable<T> GetAll();
    }
}