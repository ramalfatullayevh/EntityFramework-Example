namespace SpotifyEF.Models
{
    internal class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public ICollection<ArtistMusic> ArtistMusics { get; set; }
    }
}
