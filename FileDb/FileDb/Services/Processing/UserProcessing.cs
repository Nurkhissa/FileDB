using FileDb.Services.Users;
using FileDb.Models;
using FileDb.Services.Identityes;


namespace FileDb.Services.Processing
{
    internal class UserProcessing : IUserProcessing
    {
        private readonly IUserService userService;
        private readonly IdentityService identityService;

        public UserProcessing(IUserService userService,
                    IdentityService identitiyService)
        {
            this.userService = userService;
            identityService = identitiyService;
        }

        public User CreateNewUser(string name)
        {
            User user = new User();
            user.Id = identityService.GetNewId();
            user.Name = name;
            userService.AddUser(user);

            return user;
        }

        public List<User> DisplayUsers() =>
            userService.AllUsers();

        public void DeleteUser(int id) =>
            userService.Delete(id);

        public bool UpdateUser(int id, string name)
        {
            User user = new User();
            user.Id = id;
            user.Name = name;
            return userService.Update(user);
        }
    }
}