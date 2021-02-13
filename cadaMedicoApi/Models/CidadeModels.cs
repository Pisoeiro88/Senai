using System.Collections.Generic;

namespace cadaMedicoApi.Models
{
    public class CidadeModels
    {
        public CidadeModels(){}
        public CidadeModels(int id, string nome, string estado)
        {
            this.Id = id;
            this.Nome = nome;
            this.Estado = estado;
        }
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Estado {get; set;}
        public IEnumerable<MedicoCidade> MedicoCidade { get; set; }
    }
}