using AutoMapper;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile() 
        {
            CreateMap<Document, Models.DocumentDto>().ReverseMap();
        }
    }
}