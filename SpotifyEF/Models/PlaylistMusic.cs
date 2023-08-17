namespace SpotifyEF.Models
{
    internal class PlaylistMusic
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int MusicId { get; set; }
        public Playlist Playlist { get; set; }
        public Music Music { get; set; }
    }
}
