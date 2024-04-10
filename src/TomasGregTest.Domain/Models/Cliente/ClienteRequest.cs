namespace ThomasGregTest.Domain.Models.Cliente
{
    public class ClienteRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Logotipo { get; set; }
        public IEnumerable<Logradouro.Logradouro> Logradouros { get; set; }
    }
}
