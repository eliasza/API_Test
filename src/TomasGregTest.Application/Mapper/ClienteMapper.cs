
namespace ThomasGregTest.Application.Mapper
{
    public class ClienteMapper: Profile
    {
        public ClienteMapper()
        {
            MappingCliente();
        }

        private void MappingCliente()
        {
            CreateMap<Cliente, ClienteRequest>().ReverseMap();
        }
    }
}
