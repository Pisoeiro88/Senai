using System.Linq;
using System.Threading.Tasks;
using cadaMedicoApi.Data;
using cadaMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace cadeMedicoApi.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }


        public async Task<MedicoModels[]> GetAllMedicoModelsAsync(bool includeMedico = false)
        {
             IQueryable<MedicoModels> query = _context.Medicos;

            if(includeMedico){
                query = query.Include(me => me.MedicoCidade)
                             .ThenInclude(mc => mc.Cidade)
                             .Include(em => em.MedicoEspecialidade)
                             .ThenInclude(e => e.Especialidade);
            }
            query = query.AsNoTracking().OrderBy(m =>m.Id);

            return await query.ToArrayAsync();
        }
        public async Task<MedicoModels[]> GetMedicoModelsByEspeciaidadeId(int EspecialidadeId, 
                                                                        bool includeEspecialidade){

            IQueryable<MedicoModels> query = _context.Medicos;

            if(includeEspecialidade){
                query = query.Include( me => me.MedicoEspecialidade)
                                .ThenInclude(e => e.Especialidade);

            } 

            query = query.AsNoTracking()
                            .OrderBy(medico => medico.Id)
                            .Where(medico => medico.MedicoEspecialidade.
                            Any(me => me.EspecialidadeId == EspecialidadeId));

            return await query.ToArrayAsync();
        }

        public async Task<MedicoModels> GetMedicoModelsById(int medicoId, bool includeCidade)
        {
            IQueryable<MedicoModels> query = _context.Medicos;
            
            if(includeCidade){
                query = query.AsNoTracking()
                                .Include(c => c.MedicoCidade)
                                .ThenInclude(mc => mc.Cidade)
                                .Include(em => em.MedicoEspecialidade)
                                .ThenInclude(e => e.Especialidade);
            }

            query = query.AsNoTracking()
                            .OrderBy(medico => medico.Id)
                            .Where(medico => medico.Id == medicoId);

            return await query.FirstOrDefaultAsync();
        }
        ////
        public async Task<CidadeModels[]> GetAllCidadeModelsAsync(bool includeCidade = false)
        {
             IQueryable<CidadeModels> query = _context.Cidades;

            if(includeCidade){
                query = query.Include(me => me.MedicoCidade)
                             .ThenInclude(c => c.Medico)
                             .ThenInclude(me => me.MedicoEspecialidade)
                             .ThenInclude(e => e.Especialidade);
            }
            query = query.AsNoTracking().OrderBy(c =>c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<CidadeModels> GetCidadeModelsById(int cidadeId, bool includeMedico){
            IQueryable<CidadeModels> query = _context.Cidades;
            
            if(includeMedico){
                query = query.Include(c => c.MedicoCidade)
                                .ThenInclude(m => m.Medico)
                                .ThenInclude(em => em.MedicoEspecialidade)
                                .ThenInclude(e => e.Especialidade);
            }

            query = query.AsNoTracking()
                            .OrderBy(cidade => cidade.Id)
                            .Where(cidade => cidade.Id == cidadeId);

            return await query.FirstOrDefaultAsync();
        }
        //Usuario
        public async Task<UsuarioModels[]> GetAllUsuarioModelsAsync(bool includeUsuario)
        {
            IQueryable<UsuarioModels> query = _context.Usuarios;

            if(includeUsuario){
                query = query.Include(u => u.Usuario);
            }
            query = query.AsNoTracking().OrderBy(m =>m.Id);

            return await query.ToArrayAsync();
        }
        public async Task<UsuarioModels> GetUsuarioModelsById(int usuario, bool includeUsuario)
        {
            IQueryable<UsuarioModels> query = _context.Usuarios;
            
            if(includeUsuario){
                query = query.AsNoTracking()
                                .Include(u => u.Usuario);
            }

            query = query.AsNoTracking()
                            .OrderBy(usuario => usuario.Id);

            return await query.FirstOrDefaultAsync();
        }
    }
}
