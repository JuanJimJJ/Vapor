using AutoMapper;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Users;
using VaporApp.Application.Responses;
using VaporApp.Domain.Entities;

namespace VaporApp.Application.Mappings
{
    public class UsersMappingProfile : Profile
    {
        public UsersMappingProfile()
        {
            CreateMap<CreateUsersRequest, Users>();
            CreateMap<Users, CreateUsersRequest>();

            CreateMap<UpdateUsersRequest, Users>();
            CreateMap<Users, UpdateUsersRequest>();

            CreateMap<Users, UsersResponse>();
        }
    }
}
