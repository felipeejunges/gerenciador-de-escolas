namespace gerenciador_de_escolas.Repository
{
    public interface IRepository<TEntity>
    {
         TEntity getById(int id);
         void save(TEntity entity);
    }
}