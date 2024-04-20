namespace SupportService
{
    public class Level2Support : SupportHandler
    {
        public override void Handle(Request request)
        {
            if (request.ProblemDifficulty > 5 && request.ProblemDifficulty <= 10)
            {
                Console.WriteLine("Make sure all cables are properly connected");
            }
            else
            {
                Next(request);
            }
        }
    }
}
