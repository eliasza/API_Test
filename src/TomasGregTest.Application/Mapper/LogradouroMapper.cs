
namespace ThomasGregTest.Application.Mapper
{
    public class LogradouroMapper : Profile
    {
        public LogradouroMapper()
        {
            MappingLogradouro();
        }

        private void MappingLogradouro()
        {
            CreateMap<Logradouro, LogradouroRequest>().ReverseMap();
        }
    }
}
