namespace ImageLightHTML
{
    public class Image : LightElementNode
    {
        IImageLoader loader;
        string href;

        public Image(string href,IImageLoader loader) : base("img", "inline-block", false)
        {
            this.loader = loader;
            this.href = href;
        }

        public void ChangeLoader(IImageLoader loader)
        {
            this.loader = loader;
        }

        public void Display()
        {
            loader.Load(href);
        }
    }
}
