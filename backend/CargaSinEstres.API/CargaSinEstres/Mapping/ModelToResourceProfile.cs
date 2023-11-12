using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Review, ReviewResource>();
        CreateMap<BookingHistory, BookingHistoryResource>();
    }
}