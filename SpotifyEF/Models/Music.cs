namespace SpotifyEF.Models
{
    internal class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<PlaylistMusic> PlaylistMusics { get; set; }
        public ICollection<ArtistMusic> ArtistMusics { get; set; }
    }
}
