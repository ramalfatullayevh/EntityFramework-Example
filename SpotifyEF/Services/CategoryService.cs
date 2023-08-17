using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class CategoryService : Iservice<Category>
    {
        public void Delete(int id)
        {
            Category existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Categories.FirstOrDefault(c => c.Id == id);
                if (existed!=null)
                {
                    context.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Category succesfully deleted.");
                }
                else
                {
                    Console.WriteLine("Category does not exist.");
                }
            }
        }

        public List<Category> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public void Update(Category upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Categories.FirstOrDefault(c=>c.Id == id)!=null)
                {
                    Category category = context.Categories.FirstOrDefault(c=>c.Id==id);
                    category.Name = upd.Name;
                    context.SaveChanges();
                    Console.WriteLine("Category information successfully updated.");
                }
            }
        }

        public void Add(string name)
        {
            Category category = new Category
            {
                Name = name,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
                Console.WriteLine("Category name successfully added.");
            }
        }
    }
}
