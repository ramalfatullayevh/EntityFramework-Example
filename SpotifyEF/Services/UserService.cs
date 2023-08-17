using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class UserService : Iservice<User>
    {
        public void Delete(int id)
        {
            User existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Users.FirstOrDefault(u => u.Id == id);
                if (existed!=null)
                {
                    context.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("User succesfully deleted.");
                }
            }
        }

        public List<User> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Users.ToList();
            }
        }

        public void Update(User upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Users.FirstOrDefault(u=>u.Id == id)!=null)
                {
                    User user = context.Users.FirstOrDefault(u=>u.Id == id);  
                    user.Name = upd.Name;
                    user.Surname = upd.Surname;
                    user.Username = upd.Username;
                    user.Password = upd.Password;
                    user.RoleId = upd.RoleId;
                    context.SaveChanges();
                    Console.WriteLine("User informations successfully updtaed.");
                }
            }
        }

        public void Add(string name, string surname, string username, string password, int roleid )
        {
            User user = new User
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = password,
                RoleId = roleid
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                Console.WriteLine("User successfully added");

            }
        }

    }
}
