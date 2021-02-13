using System.Collections.Generic;

namespace cadaMedicoApi.Models
{
    public class EspecialidadeModels
    {
        public EspecialidadeModels()
        {}
        public EspecialidadeModels(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public int Id {get; set;}
        public string Nome {get; set;}
        public IEnumerable<MedicoEspecilidade> MedicoEspecialidade { get; set; }
     }
}