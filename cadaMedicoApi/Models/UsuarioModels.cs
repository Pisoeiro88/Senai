namespace cadaMedicoApi.Models
{
    public class UsuarioModels
    {
        public UsuarioModels(){}
        public UsuarioModels(int id, string nome, string login, string senha, int Privilegioid)
        {
            this.Id = id;
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.PrivilegioId = Privilegioid;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PrivilegioId { get; set; }
    }
}