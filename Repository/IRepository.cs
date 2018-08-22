using System.Collections.Generic;

namespace gerenciador_de_escolas.Repository
{
    public interface IRepository<TEntity>
    {
         TEntity getById(int id);
         IEnumerable<TEntity> All();
         void remove(int id);
         void save(TEntity entity);
    }
}