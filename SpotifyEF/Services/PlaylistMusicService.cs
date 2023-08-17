using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class PlaylistMusicService : Iservice<PlaylistMusic>
    {
        public void Delete(int id)
        {
            PlaylistMusic existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.PlaylistMusics.FirstOrDefault(a => a.Id == id);
                if (existed != null)
                {
                    context.PlaylistMusics.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Delered succesfully.");
                }
            }
        }

        public List<PlaylistMusic> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.PlaylistMusics.ToList();
            }
        }

        public void Update(PlaylistMusic upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.PlaylistMusics.FirstOrDefault(a => a.Id == id) != null)
                {
                    PlaylistMusic playlistMusic = context.PlaylistMusics.FirstOrDefault(a => a.Id == id);
                    playlistMusic.PlaylistId = upd.PlaylistId;
                    playlistMusic.MusicId = upd.MusicId;
                    context.SaveChanges();
                    Console.WriteLine("Successfully updated.");
                }
            }
        }

        public void Add(int playlistid, int musicid)
        {
            PlaylistMusic playlistmusic = new PlaylistMusic
            {
                PlaylistId = playlistid,
                MusicId = musicid,
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.PlaylistMusics.Add(playlistmusic);
                context.SaveChanges();
                Console.WriteLine("Successfully added.");
            }
        }
    }
}
