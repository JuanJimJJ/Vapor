using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private DBVaporContext _context;
        public UsersRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<Users> GetUsers()
        {
            return _context.Users;
        }

        public Users GetUsersById(int idUser)
        {
            return _context.Users.FirstOrDefault(x => x.IdUser == idUser);
        }

        public void InsertUsers(Users users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
        }

        public void UpdateUsers(Users users)
        {
            var userExisting = _context.Users.FirstOrDefault(x => x.IdUser == users.IdUser);
            userExisting.UserEmail = users.UserEmail;
            userExisting.UserPhone = users.UserPhone;
            userExisting.UserAddress = users.UserAddress;
            userExisting.UserCity = users.UserCity;
            userExisting.UserState = users.UserState;
            _context.SaveChanges();
        }

        public void DeleteUsers(int idUser)
        {
            var salaExistente = _context.Users.FirstOrDefault(x => x.IdUser == idUser);
            _context.Users.Remove(salaExistente);
            _context.SaveChanges();
        }
    }
}
