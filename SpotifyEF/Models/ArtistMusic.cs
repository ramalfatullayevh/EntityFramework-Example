namespace SpotifyEF.Models
{
    internal class ArtistMusic
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int MusicId { get; set; }
        public Artist Artist { get; set; }
        public Music Music { get; set; }
    }
}
