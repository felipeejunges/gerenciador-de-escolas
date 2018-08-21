using System.Threading.Tasks;
namespace gerenciador_de_escolas.Config
{
   public interface IUnitOfWork
    {
         Task Commit();
    }
}