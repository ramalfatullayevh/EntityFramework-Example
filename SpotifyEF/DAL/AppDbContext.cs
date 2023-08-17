using Microsoft.EntityFrameworkCore;
using SpotifyEF.Models;

namespace SpotifyEF.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server = DESKTOP-UM825JL\\SQLEXPRESS; Database = SpotifyEF; Integrated security = true; Trusted_connection = true; Encrypt=false;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistMusic> ArtistMusics { get; set; }
        public DbSet<PlaylistMusic> PlaylistMusics { get; set; }
    }
}
