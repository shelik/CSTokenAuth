using System.Linq;
using Auth.Models;
 
namespace AuthStore
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                      Login="admin@gmail.com", 
                      Password="12345", 
                      Role = Role.Admin 
                    },
                    new User
                    {
                      Login="qwerty@gmail.com", 
                      Password="55555", 
                      Role = Role.User 
                    }
                );
                context.SaveChanges();
            }
        }
    }
}