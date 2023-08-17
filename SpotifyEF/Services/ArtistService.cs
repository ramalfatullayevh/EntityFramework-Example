using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class ArtistService : Iservice<Artist>
    {
        public void Delete(int id)
        {
            Artist existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Artists.FirstOrDefault(a => a.Id == id);
                if (existed!=null)
                {
                    context.Artists.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Artist successfully deleted.");
                }
            }
        }

        public List<Artist> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Artists.ToList();
            }
        }

        public void Update(Artist upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Artists.FirstOrDefault(a=>a.Id == id)!=null)
                {
                    Artist artist = context.Artists.FirstOrDefault(a=>a.Id == id);
                    artist.Name = upd.Name;
                    artist.Surname = upd.Surname;
                    artist.Birthday = upd.Birthday;
                    artist.Gender = upd.Gender;
                    context.SaveChanges();
                    Console.WriteLine("Artist informations successfully updated.");
                }
            }
        }

        public void Add(string name, string surname, DateTime birthady, string gender)
        {
            Artist artist = new Artist
            {
                Name = name,
                Surname = surname,
                Birthday = birthady,
                Gender = gender,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Artists.Add(artist);
                context.SaveChanges();
                Console.WriteLine("Artist successfully added.");
            }
        }
    }
}
