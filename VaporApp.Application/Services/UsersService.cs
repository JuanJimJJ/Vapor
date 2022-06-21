using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests.Users;
using VaporApp.Application.Requests;

namespace VaporApp.Application.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;
        private readonly IMapper _mapper;
        public UsersService(IUsersRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<UsersResponse> GetUsers()
        {
            var users = _repository.GetUsers();
            var usersResponse = _mapper.Map<IEnumerable<UsersResponse>>(users);
            return usersResponse;
        }

        public UsersResponse GetUsersById(int idUser)
        {
            var users = _repository.GetUsersById(idUser);
            var usersResponse = _mapper.Map<UsersResponse>(users);
            return usersResponse;
        }

        public void InsertUsers(CreateUsersRequest request)
        {
            var users = _mapper.Map<Users>(request);
            _repository.InsertUsers(users);
        }

        public void UpdateUsers(UpdateUsersRequest users)
        {
            var user = _mapper.Map<Users>(users);
            _repository.UpdateUsers(user);
        }

        public void DeleteUsers(int idUser)
        {
            _repository.DeleteUsers(idUser);
        }
    }
}
