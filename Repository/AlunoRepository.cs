using System.Collections.Generic;
using System.Linq;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;
using Microsoft.EntityFrameworkCore;

namespace gerenciador_de_escolas.Repository
{
    public class AlunoRepository : Repository<Aluno>
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override Aluno getById(int id)
        {
            var query = _context.Set<Aluno>().Include(a => a.turma)
            .Where(e => e.id == id);
            if(query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Aluno> All()
        {
            var query = _context.Set<Aluno>().Include(a => a.turma).Include(e => e.turma.escola);

            return query.Any() ? query.ToList() : new List<Aluno>();
        }
    }
}