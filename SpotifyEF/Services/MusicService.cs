using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class MusicService : Iservice<Music>
    {
        public void Delete(int id)
        {
            Music existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Musics.FirstOrDefault(m => m.Id == id);
                if (existed!=null)
                {
                    context.Musics.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Music succesfully deleted.");
                }

            }
        }

        public List<Music> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Musics.ToList();
            }
        }

        public void Update(Music upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Musics.FirstOrDefault(m=>m.Id == id)!=null)
                {
                    Music music = context.Musics.FirstOrDefault(m => m.Id == id);
                    music.Name = upd.Name;
                    music.Duration = upd.Duration;
                    music.CategoryId = upd.CategoryId;
                    context.SaveChanges();
                    Console.WriteLine("Music informations successfully updated.");
                }
            }
        }

        public void Add(string name, int duration, int categoryid)
        {
            Music music = new Music
            {
                Name = name,
                Duration = duration,
                CategoryId = categoryid,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Musics.Add(music);
                context.SaveChanges();
                Console.WriteLine("Music succesfully added.");
            }
        }
    }
}
