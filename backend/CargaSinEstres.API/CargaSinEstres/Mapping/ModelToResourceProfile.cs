using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Review, ReviewResource>();
            CreateMap<Comment, CommentResource>();
            //CreateMap<BookingHistory, BookingHistoryResource>();

            CreateMap<BookingHistory, BookingHistoryResource>()
                .ForMember(dest => dest.HiredCompany, opt => opt.MapFrom(src => new HiredCompanyResource
                {
                    Name = src.HiredCompany.Name,
                    Logo = src.HiredCompany.Logo
                }))
                .ForMember(dest => dest.Payment, opt => opt.MapFrom(src => new PaymentResource
                {
                    Id = src.Payment.Id,
                    TotalAmount = src.Payment.TotalAmount,
                    PaymentMethod = src.Payment.PaymentMethod
                }))
                .ForMember(dest => dest.Chats, opt => opt.MapFrom(src => src.Chats))
                .ForMember(dest => dest.Workers, opt => opt.MapFrom(src => src.Workers));

            
            CreateMap<Worker, WorkerResource>()
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments));
        }
    }
}