using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.Communication;

namespace CargaSinEstres.API.CargaSinEstres.Security.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<RegisterRequest, Company>();
        CreateMap<UpdateRequest, Company>()
            .ForAllMembers(options => options.Condition(
                (source, target, property) =>
                {
                    if (property == null) return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property)) return false;
                    return true;
                }
            ));
    }
}