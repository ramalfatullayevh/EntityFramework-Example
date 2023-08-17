using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class ArtistMusicService : Iservice<ArtistMusic>
    {
        public void Delete(int id)
        {
            ArtistMusic existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.ArtistMusics.FirstOrDefault(a => a.Id == id);
                if (existed != null)
                {
                    context.ArtistMusics.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Delered succesfully.");
                }
            }
        }

        public List<ArtistMusic> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.ArtistMusics.ToList();
            }
        }

        public void Update(ArtistMusic upd, int id)
        {

            using (AppDbContext context = new AppDbContext())
            {
                if (context.ArtistMusics.FirstOrDefault(a => a.Id == id) != null)
                {
                    ArtistMusic artistMusic = context.ArtistMusics.FirstOrDefault(a => a.Id == id);
                    artistMusic.ArtistId = upd.ArtistId;
                    artistMusic.MusicId = upd.MusicId;
                    context.SaveChanges();
                    Console.WriteLine("Successfully updated.");
                }
            }
        }

        public void Add(int artistid, int musicid)
        {
            ArtistMusic artistMusic = new ArtistMusic
            {
                ArtistId = artistid,
                MusicId = musicid,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.ArtistMusics.Add(artistMusic);
                context.SaveChanges();
                Console.WriteLine("Successfully added.");
            }
        }
    }
}
