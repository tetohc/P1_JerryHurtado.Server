using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class RestaurantRepository : IRepository<Restaurante>
    {
        private readonly RestUnedContext _dbContext;

        public RestaurantRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Restaurante model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Restaurante.Add(model);
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

        public IEnumerable<Restaurante> GetAll() => _dbContext.Restaurante.ToList();

        public Restaurante GetById(int id) => _dbContext.Restaurante.FirstOrDefault(x => x.IdRestaurante == id);

        public int GetNewIdValue()
        {
            int newId = 1;
            var restaurants = _dbContext.Restaurante.ToList();
            if (restaurants.Count() > 0)
            {
                restaurants = restaurants.OrderByDescending(x => x.IdRestaurante).ToList();
                newId = restaurants.FirstOrDefault().IdRestaurante + 1;
            }
            return newId;
        }

        public bool IsEmpty()
        {
            var restaurants = _dbContext.Restaurante.Where(x => x.Estado).ToList();
            return restaurants.Count() == 0 ? true : false;
        }
    }
}