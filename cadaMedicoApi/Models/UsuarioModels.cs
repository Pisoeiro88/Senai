namespace cadaMedicoApi.Models
{
    public class UsuarioModels
    {
        public UsuarioModels(){}
        public UsuarioModels(int id, string usuario, string login, string senha, int Privilegioid)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Login = login;
            this.Senha = senha;
            this.PrivilegioId = Privilegioid;

        }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PrivilegioId { get; set; }
    }
}