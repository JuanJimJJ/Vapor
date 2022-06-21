using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Users;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface IUsersService
    {
        UsersResponse GetUsersById(int idUser);
        IEnumerable<UsersResponse> GetUsers();

        void InsertUsers(CreateUsersRequest users);

        void UpdateUsers(UpdateUsersRequest users);

        void DeleteUsers(int idUser);
    }
}
