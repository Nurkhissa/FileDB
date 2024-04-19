using FileDb.Models;

namespace FileDb.Services.Processing
{
    internal interface IUserProcessing
    {
        User CreateNewUser(string name);
        List<User> DisplayUsers();
        void DeleteUser(int id);
        bool UpdateUser(int id, string name);

    }
}