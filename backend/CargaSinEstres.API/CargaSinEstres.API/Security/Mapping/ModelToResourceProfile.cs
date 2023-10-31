using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Security.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Security.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Company, AuthenticateResponse>();
        CreateMap<Company, CompanyResource>();
    }
}
