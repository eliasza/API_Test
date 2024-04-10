
using System.ComponentModel.DataAnnotations.Schema;

namespace ThomasGregTest.Domain.Models.Logradouro
{
    [Table("Logradouros")]
    public class Logradouro
    {
        [Key]
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
