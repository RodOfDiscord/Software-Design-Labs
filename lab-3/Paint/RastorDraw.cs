namespace Paint
{
    public class RastorDraw : IDraw
    {
        public void Draw(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as rastor");
        }
    }
}
