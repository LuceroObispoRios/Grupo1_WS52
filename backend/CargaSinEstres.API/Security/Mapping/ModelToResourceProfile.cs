using AutoMapper;
using CargaSinEstres.API.Security.Domain.Models;
using CargaSinEstres.API.Security.Domain.Services.Communication;
using CargaSinEstres.API.Security.Resources;

namespace CargaSinEstres.API.Security.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Company, AuthenticateResponse>();
        CreateMap<Client, AuthenticateResponseClient>();
        CreateMap<Company, CompanyResource>();
        CreateMap<Client, ClientResource>();
    }
}