namespace SupportService
{
    public class Level3Support : SupportHandler
    {
        public override void Handle(Request request)
        {
            if (request.ProblemDifficulty > 10 && request.ProblemDifficulty <= 20)
            {
                Console.WriteLine("Maybe it`s a problem with a hardware. Visit tech service");
            }
            else
            {
                Next(request);
            }
        }
    }
}
