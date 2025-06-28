namespace MeuSistemaApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senhahash { get; set; }
        public string Tipo { get; set; }
    }
}
