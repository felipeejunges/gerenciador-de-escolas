using System.Collections.Generic;
using gerenciador_de_escolas.ViewModels;

namespace gerenciador_de_escolas.Repository
{
    public interface IRepository<TEntity>
    {
         TEntity getById(int id);
         IEnumerable<TEntity> All();
         void remove(int id);
         void save(TEntity entity);
        IEnumerable<TEntity> getByFK(int fkId);
    }
}