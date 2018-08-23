using System.Collections.Generic;
using System.Linq;
using gerenciador_de_escolas.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciador_de_escolas.Repository
{
    public class TurmaRepository : Repository<Turma>
    {
        public TurmaRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        public override Turma getById(int id)
        {
            var query = _context.Set<Turma>().Include(t => t.escola).Where(e => e.id == id);
            if(query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Turma> All()
        {
            var query = _context.Set<Turma>().Include(t => t.escola);

            return query.Any() ? query.ToList() : new List<Turma>();
        }
    }
}