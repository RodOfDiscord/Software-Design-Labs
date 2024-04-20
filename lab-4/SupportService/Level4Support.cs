namespace SupportService
{
    public class Level4Support : SupportHandler
    {
        public override void Handle(Request request)
        {
            if (request.ProblemDifficulty > 20 && request.ProblemDifficulty <= 25)
            {
                Console.WriteLine("Ok, here`s where u can download drivers");
            }
            else
            {
                Next(request);
            }
        }
    }
}