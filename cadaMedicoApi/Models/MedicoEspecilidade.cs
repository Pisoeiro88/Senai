using cadaMedicoApi.Models;
namespace cadaMedicoApi.Models
{
    public class MedicoEspecilidade
    {
        public MedicoEspecilidade()
        { }

        public MedicoEspecilidade(int medicoId, int especialidadeId)
        {
            this.MedicoId = medicoId;
            this.EspecialidadeId = especialidadeId;

        }
        public int MedicoId { get; set; }
        public int EspecialidadeId { get; set; }
        public MedicoModels Medico { get; set; }
        public EspecialidadeModels Especialidade { get; set; }
    }
}