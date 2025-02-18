using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;

namespace WpfApp.Services
{
    class AuthService
    {
        private readonly List<User> _users = new()
        {
            new User { Id = 1, UserName = "nikhilpj98" , Password ="password1" },
            new User { Id = 2, UserName = "mig21" , Password ="supersonic" },
             new User { Id = 3, UserName = "user" , Password ="123" }
        };

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
