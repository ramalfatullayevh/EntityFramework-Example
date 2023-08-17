using Microsoft.EntityFrameworkCore;
using SpotifyEF.DAL;
using SpotifyEF.Models;
using SpotifyEF.Services;

namespace SpotifyEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryService ctgservice = new CategoryService();
            //Add Method:
            //service.Add("Rock");
            //service.Add("Rap");
            //service.Add("Pop");

            //GetAll Method:
            //foreach (var item in service.GetAll())
            //{
            //    Console.WriteLine($"{item.Id}) {item.Name}");
            //}

            //Delete Method:
            //service.Delete(2);

            //Update Method:
            //Category category = new Category
            //{
            //    Name = "PopRock"
            //};

            //service.Update(category, 3);


            MusicService mscservice = new MusicService();
            //Add method:
            //mscservice.Add("Dive", 300, 1);
            //mscservice.Add("Fallen Star", 310, 3);
            //mscservice.Add("About A Girl", 280, 1);
            //mscservice.Add("Swim", 270, 3);
            //mscservice.Add("A Little Death", 269, 1);

            //Delete Method:
            //mscservice.Delete(5);

            //Update Method:
            //Music music = new Music
            //{
            //    Name = "Right Here",
            //    Duration = 290,
            //    CategoryId = 3
            //};
            //mscservice.Update(music, 4);

            //GetAll Method:
            //foreach (var item in mscservice.GetAll())
            //{
            //    Console.WriteLine($"{item.Id}) Name: {item.Name}, Duration: {item.Duration}, Category Id: {item.CategoryId}");
            //}


            ArtistService artservice = new ArtistService();
            //Add Method:
            //artservice.Add("Kurt", "Cobain", new DateTime(1967, 02, 20), "Male");
            //artservice.Add("Jessse", "Rutherford", new DateTime(1991, 08, 21), "Male");
            //artservice.Add("Mitchel", "Cave", new DateTime(1996, 03, 13), "Male");

            //Delete Method:
            //artservice.Delete(4);

            //Update Method:
            //Artist artist = new Artist
            //{
            //    Name = "Clinton",
            //    Surname = "Anthony",
            //    Birthday = new DateTime(1999,11,30),
            //    Gender = "Male"
            //};
            //artservice.Update(artist, 3);

            //GetAll Method:
            //foreach (var item in artservice.GetAll())
            //{
            //    Console.WriteLine($"{item.Id}) Name: {item.Name}, Surname: {item.Surname}, Birthaday: {item.Birthday}, Gender: {item.Gender}");
            //}

            AppDbContext context = new AppDbContext();
            //Get All Music and Music's Category (one-to-many)
            //Music music = context.Musics.Include(m=>m.Category).FirstOrDefault(m=>m.Id == 1);
            //Console.WriteLine($"{music.Id}) Name: {music.Name}, Duration: {music.Duration}, Category: {music.Category.Name}");


            // GetAll This Category's musics. (Forexample: Rock musics)
            //Category category = context.Categories.Include(c=>c.Musics).FirstOrDefault(c=>c.Id == 1);
            //foreach (var item in category.Musics)
            //{
            //    Console.WriteLine($"Music Name: {item.Name}");
            //}

            //Get All Artists and  Musics (many-to-many)

            //ArtistMusicService artistMusicService = new ArtistMusicService();
            //artistMusicService.Add(1, 1);
            //artistMusicService.Add(1, 3);
            //artistMusicService.Add(2, 2);
            //artistMusicService.Add(3, 4);

            //List<Artist> artist = context.Artists.Include(a => a.ArtistMusics).ThenInclude(artmcs => artmcs.Music).ToList();

            //foreach (var item in artist)
            //{  
            //    Console.WriteLine("----------------------");
            //    Console.WriteLine(item.Name + item.Surname + ": ");
            //    foreach (var mcs in item.ArtistMusics)
            //    {
            //        Console.WriteLine(mcs.Music.Name);
              

            //    }
            //}
        }
    }
}