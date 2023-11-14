using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveClientResource, Client>();
        CreateMap<SaveReviewResource, Review>();
        CreateMap<BookingHistory, BookingHistoryResource>();
    }
}