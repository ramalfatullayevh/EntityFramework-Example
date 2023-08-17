namespace SpotifyEF.Interfaces
{
    internal interface Iservice<T>
    {
        void Delete(int id);
        void Update(T upd, int id);
        List<T> GetAll();
    }
}
