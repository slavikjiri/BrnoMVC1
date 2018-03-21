using AutoMapper;
using BrnoMvc1.Web.Models;

namespace BrnoMvc1.Web.Mapper
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            this.CreateMap<Movie, MovieViewModel>().ReverseMap();
        }

    }
}