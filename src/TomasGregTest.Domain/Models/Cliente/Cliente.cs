
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ThomasGregTest.Domain.Models.Cliente
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Logotipo { get; set; }
    }
}
