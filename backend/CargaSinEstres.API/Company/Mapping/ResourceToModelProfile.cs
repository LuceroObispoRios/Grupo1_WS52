using AutoMapper;
using CargaSinEstres.API.Company.Domain.Services.Communication;

namespace CargaSinEstres.API.Company.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<RegisterRequest, Domain.Models.Company>();
        CreateMap<UpdateRequest, Domain.Models.Company>()
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