using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface IUsersRepository
    {
        Users GetUsersById(int idUser);
        IEnumerable<Users> GetUsers();

        void InsertUsers(Users users);

        void UpdateUsers(Users users);

        void DeleteUsers(int idUser);
    }
}
