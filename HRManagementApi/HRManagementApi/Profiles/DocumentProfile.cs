using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagementApi.Models;

namespace HRManagementApi.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<DocumentDtoApi, DocumentDto>();
            CreateMap<DocumentDto, Document>();
        }
    }
}
