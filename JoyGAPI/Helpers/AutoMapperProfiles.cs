using AutoMapper;

namespace JoyGAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<CarPoolOpportunityRequestDto, CarPoolOpportunity>()
            //   //.ForMember(x => x.PoolId, opt => opt.MapFrom(src => Guid.NewGuid().ToString().Substring(0, 6)))
            //   /*.ForMember(x => x.DaysAvailable, opt => new List<AvailableDays>())*/;
        }
    }
}
