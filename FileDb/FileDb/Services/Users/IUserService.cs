using FileDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDb.Services.Users
{
    internal interface IUserService
    {
        User AddUser(User user);
        List<User> AllUsers();
        bool Update(User user);
        void Delete(int id);
    }
}
