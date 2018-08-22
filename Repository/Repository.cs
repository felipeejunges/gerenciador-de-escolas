using System;
using System.Collections.Generic;
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

        public virtual IEnumerable<TEntity> All()
        {
            var query = _context.Set<TEntity>();

            if(query.Any())
                return query.ToList();

            return new List<TEntity>();
        }

        public TEntity getById(int id) {
            return _context.Set<TEntity>().SingleOrDefault(e => e.id == id);
        }

        public void remove(int id)
        {
            TEntity e = getById(id);
            if(e != null)
                _context.Remove(e);
        }

        public void save(TEntity entity) {
             _context.Set<TEntity>().Add(entity);
         }
    }
}