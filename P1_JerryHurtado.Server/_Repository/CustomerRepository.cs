using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class CustomerRepository : ICustomerRepository<Cliente>
    {
        private readonly RestUnedContext _dbContext;

        public CustomerRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Cliente model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Cliente.Add(model);
                _dbContext.SaveChanges();
                transaccion.Commit();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                transaccion.Rollback();
                return false;
            }
        }

        public IEnumerable<Cliente> GetAll() => _dbContext.Cliente.ToList();

        public Cliente GetById(string id) => _dbContext.Cliente.FirstOrDefault(x => x.IdCliente == id);
    }
}