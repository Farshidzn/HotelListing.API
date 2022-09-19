using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.Country;
using HotelListing.Models.Hotel;
using HotelListing.Models.Users;

namespace HotelListing.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();


        }
    }
}
