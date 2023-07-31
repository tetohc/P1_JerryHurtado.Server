namespace P1_JerryHurtado.Server._Repository.Interfaces
{
    public interface ICustomerRepository<Cliente>
    {
        bool Add(Cliente model);

        Cliente GetById(string id);

        IEnumerable<Cliente> GetAll();
    }
}