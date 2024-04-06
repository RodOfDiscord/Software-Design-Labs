namespace Paint
{
    public class PixelDraw : IDraw
    {
        public void Draw(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as pixel");
        }
    }
}
