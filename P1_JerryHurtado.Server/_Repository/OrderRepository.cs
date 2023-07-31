using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class OrderRepository : IOrderRepository<Pedido>
    {
        private readonly RestUnedContext _dbContext;

        public OrderRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Pedido model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Pedido.Add(model);
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

        public IEnumerable<Pedido> GetAll() => _dbContext.Pedido.ToList();

        public IEnumerable<Pedido> GetAllByCustomer(string customerId)
            => _dbContext.Pedido.Include(x => x.IdClienteNavigation)
                .Include(x => x.IdPlatoNavigation).Where(x => x.IdCliente.Trim() == customerId.Trim()).ToList();

        public Pedido GetById(int id) => _dbContext.Pedido.FirstOrDefault(x => x.IdPedido == id);

        public IEnumerable<Pedido> GetExtasByOrder(int orderId)
            => _dbContext.Pedido.Include(x => x.IdClienteNavigation)
                                .Include(x => x.IdPlatoNavigation)
                                .Include(x => x.IdExtra)
                                .Where(x => x.IdPedido == orderId && x.IdExtra.Any())
                                .ToList();

        public int GetNewIdValue()
        {
            int newId = 1;
            var list = GetAll();
            if (list.Count() > 0)
            {
                list = list.OrderByDescending(x => x.IdPedido).ToList();
                newId = list.FirstOrDefault().IdPedido + 1;
            }
            return newId;
        }
    }
}