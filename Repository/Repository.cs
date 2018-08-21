using System;
using System.Linq;
using gerenciador_de_escolas.Models;

namespace gerenciador_de_escolas.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private ApplicationDbContext _context;

        public Repository(ApplicationDbContext context) {
            _context = context;
        }

        public TEntity getById(int id) {
            return _context.Set<TEntity>().SingleOrDefault(e => e.id == id);
        }
         public void save(TEntity entity) {
             _context.Set<TEntity>().Add(entity);

         }
    }
}