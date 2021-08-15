using System.Collections.Generic;
using System.Linq;
using UserAuthenticate.Models;

namespace UserAuthenticate.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username,string password)
        {
            var users = new List<User>();
            users.Add(new User{Id=1, Username = "manager", Password= "manager", Role= "manager"});
            users.Add(new User{Id=2, Username = "employee", Password= "employee" , Role= "employee"});
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
            
        }
    }
}