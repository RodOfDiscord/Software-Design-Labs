namespace ImageLightHTML
{
    public class LocalLoader : IImageLoader
    {
        public void Load(string href)
        {
            Console.WriteLine("Loading image from local storage");
        }
    }
}
