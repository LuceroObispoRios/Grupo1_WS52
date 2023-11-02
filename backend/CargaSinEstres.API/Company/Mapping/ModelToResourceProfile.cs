using AutoMapper;
using CargaSinEstres.API.Company.Domain.Services.Communication;
using CargaSinEstres.API.Company.Resources;

namespace CargaSinEstres.API.Company.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Domain.Models.Company, AuthenticateResponse>();
        CreateMap<Domain.Models.Company, CompanyResource>();
    }
}