namespace cadaMedicoApi.Models
{
    public class MedicoCidade
    {
        public MedicoCidade()
        {

        }
        public MedicoCidade(int medicoId, int cidadeId, MedicoModels medico, CidadeModels cidade)
        {
            this.MedicoId = medicoId;
            this.CidadeId = cidadeId;
            this.Medico = medico;
            this.Cidade = cidade;
        }

        public int MedicoId {get; set;}
        public int CidadeId {get; set;}
        public MedicoModels Medico {get; set;}
        public CidadeModels Cidade {get; set;}

    }
}