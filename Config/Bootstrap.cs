using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using gerenciador_de_escolas.Repository;
using gerenciador_de_escolas.Storer;

namespace gerenciador_de_escolas.Config
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, String conection) {
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(conection));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(AlunoStorer));
            services.AddSingleton(typeof(EscolaStorer));
            services.AddSingleton(typeof(TurmaStorer));
            services.AddSingleton(typeof(IUnitOfWork), typeof(UnitOfWork));
        }

    }
}