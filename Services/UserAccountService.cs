using MegaPay.Authentication;
using MegaPay.Models;

namespace MegaPay.Services
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount{UserName = "admin", Password = "admin123", Role = "Administrator"},
                new UserAccount{UserName = "user", Password = "user", Role = "User"}
            };
        }

        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}

