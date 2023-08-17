using SpotifyEF.DAL;
using SpotifyEF.Interfaces;
using SpotifyEF.Models;

namespace SpotifyEF.Services
{
    internal class PlaylistService : Iservice<Playlist>
    {
        public void Delete(int id)
        {
            Playlist existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Playlists.FirstOrDefault(p => p.Id == id);
                if (existed!=null)
                {
                    context.Playlists.Remove(existed);
                    context.SaveChanges();
                    Console.WriteLine("Playlist successfully deleted.");
                }
            }
        }

        public List<Playlist> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Playlists.ToList();
            }
        }

        public void Update(Playlist upd, int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Playlists.FirstOrDefault(p=>p.Id == id)!= null)
                {
                    Playlist playlist = context.Playlists.FirstOrDefault(p=>p.Id == id);
                    playlist.Name = upd.Name;
                    playlist.UserId = upd.UserId;
                    context.SaveChanges();
                    Console.WriteLine("Playlist informations succesfully deleted.");
                }
            }
        }
    }
}
