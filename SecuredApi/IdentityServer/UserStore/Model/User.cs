using System.Collections.Generic;

namespace IdentityServer.UserStore.Model
{
    public class User
    {
        public string Subject { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public IList<UserClaim> UserClaims { get; set; }

        public User()
        {
            UserClaims = new List<UserClaim>();
        }
    }
}