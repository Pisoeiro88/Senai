namespace cadaMedicoApi.Models
{
    public class PrivilegioModels
    {
        public PrivilegioModels(){}
        public PrivilegioModels(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}