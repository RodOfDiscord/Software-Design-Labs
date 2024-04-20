namespace ImageLightHTML
{
    public class NetworkLoader : IImageLoader
    {
        public void Load(string href)
        {
            Console.WriteLine("Loading image from the internet");
        }
    }
}
