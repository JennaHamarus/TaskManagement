using AutoMapper;
using backend.Core.Dtos.Activity;
using backend.Core.Dtos.Job;
using backend.Core.Entities;

namespace backend.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //Activity
            CreateMap<ActivityCreateDto, Activity>();
            CreateMap<Activity, ActivityGetDto>();

            //Task/Job
            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobGetDto>()
                .ForMember(dest => dest.ActivityName, opt => opt.MapFrom(src => src.Activity.Name));
        }
    }
}
