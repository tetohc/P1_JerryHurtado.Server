using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class DishCategoryRepository : IRepository<CategoriaPlato>
    {
        private readonly RestUnedContext _dbContext;

        public DishCategoryRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(CategoriaPlato model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.CategoriaPlato.Add(model);
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

        public IEnumerable<CategoriaPlato> GetAll() => _dbContext.CategoriaPlato.ToList();

        public CategoriaPlato GetById(int id) => _dbContext.CategoriaPlato.FirstOrDefault(x => x.IdCategoria == id);

        public int GetNewIdValue()
        {
            int newId = 1;
            var list = _dbContext.CategoriaPlato.ToList();
            if (list.Count() > 0)
            {
                list = list.OrderByDescending(x => x.IdCategoria).ToList();
                newId = list.FirstOrDefault().IdCategoria + 1;
            }
            return newId;
        }

        public bool IsEmpty()
        {
            var list = _dbContext.CategoriaPlato.Where(x => x.Estado).ToList();
            return list.Count() == 0 ? true : false;
        }
    }
}