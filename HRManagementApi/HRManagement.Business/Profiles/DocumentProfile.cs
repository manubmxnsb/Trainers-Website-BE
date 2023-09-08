
using AutoMapper;

namespace HRManagement.Business.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile() 
        {
            CreateMap<DataAccess.Entities.Document, Models.DocumentDTO>();
        }
        
    }
}
