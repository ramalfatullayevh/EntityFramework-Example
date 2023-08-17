using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class RoleService : Iservice<Role>
    {
        public void Delete(int id)
        {
            Role existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Roles.FirstOrDefault(u=>u.Id == id);
                if (existed!=null)
                {
                    context.Roles.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Role successfully deleted.");
                }
            }
        }

        public List<Role> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Roles.ToList();
            }
        }

        public void Update(Role upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Roles.FirstOrDefault(r=>r.Id == id)!=null)
                {
                    Role role = context.Roles.FirstOrDefault(r => r.Id == id);
                    role.Name = upd.Name;
                    context.SaveChanges();
                    Console.WriteLine("Role information successfully updated.");
                }
            }
        }

        public void Add(string name)
        {
            Role role = new Role
            {
                Name = name,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Roles.Add(role);
                context.SaveChanges();
                Console.WriteLine("Role succesfully added.");
            }
        }
    }
}
