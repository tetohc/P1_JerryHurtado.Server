using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class DishRepository : IRepository<Plato>
    {
        private readonly RestUnedContext _dbContext;

        public DishRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Plato model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Plato.Add(model);
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

        public IEnumerable<Plato> GetAll() => _dbContext.Plato.Include(x => x.IdCategoriaNavigation).ToList();

        public Plato GetById(int id) => _dbContext.Plato.FirstOrDefault(x => x.IdPlato == id);

        public int GetNewIdValue()
        {
            int newId = 1;
            var list = _dbContext.Plato.ToList();
            if (list.Count() > 0)
            {
                list = list.OrderByDescending(x => x.IdPlato).ToList();
                newId = list.FirstOrDefault().IdPlato + 1;
            }
            return newId;
        }

        public bool IsEmpty()
        {
            var list = GetAll();
            return list.Count() == 0 ? true : false;
        }
    }
}