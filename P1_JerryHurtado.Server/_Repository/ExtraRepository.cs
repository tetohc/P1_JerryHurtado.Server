using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server._Repository.ContextDB;
using P1_JerryHurtado.Server._Repository.Interfaces;
using P1_JerryHurtado.Server.Models.ModelsDB;

namespace P1_JerryHurtado.Server._Repository
{
    public class ExtraRepository : IRepository<Extra>
    {
        private readonly RestUnedContext _dbContext;

        public ExtraRepository(RestUnedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Extra model)
        {
            using var transaccion = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.Extra.Add(model);
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

        public IEnumerable<Extra> GetAll() => _dbContext.Extra.Include(x => x.IdCategoriaNavigation).ToList();

        public Extra GetById(int id) => _dbContext.Extra.FirstOrDefault(x => x.IdExtra == id);

        public int GetNewIdValue()
        {
            int newId = 1;
            var list = _dbContext.Extra.ToList();
            if (list.Count() > 0)
            {
                list = list.OrderByDescending(x => x.IdExtra).ToList();
                newId = list.FirstOrDefault().IdExtra + 1;
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