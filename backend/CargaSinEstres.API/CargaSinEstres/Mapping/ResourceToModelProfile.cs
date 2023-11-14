using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveReviewResource, Review>();
        CreateMap<UpdateCommentResource, Worker>()
            .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments));
    }
}