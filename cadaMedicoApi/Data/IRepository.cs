using System.Threading.Tasks;
using cadaMedicoApi.Models;

namespace cadaMedicoApi.Data
{
    // Interface não implmenta metodo, apenas assinaturas
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();
         
         //Medico
         Task<MedicoModels[]> GetAllMedicoModelsAsync(bool includeMedico);
         Task<MedicoModels[]> GetMedicoModelsByEspeciaidadeId(int Especialidade, bool includeEspecialidade);
         Task<MedicoModels> GetMedicoModelsById(int medico, bool includeCidade);
         //Cidade
         Task<CidadeModels[]> GetAllCidadeModelsAsync(bool includeCidade);
         Task<CidadeModels> GetCidadeModelsById(int cidade, bool includeMedico);
    }
}