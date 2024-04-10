
namespace ThomasGregTest.Domain.Models.Logradouro
{
    public class LogradouroRequest
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
