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
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(AlunoStorer));
            services.AddScoped(typeof(EscolaStorer));
            services.AddScoped(typeof(TurmaStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }

    }
}