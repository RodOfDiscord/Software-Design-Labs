namespace SupportService
{
    public class Level1Support : SupportHandler
    {
        public override void Handle(Request request)
        {
            if (request.ProblemDifficulty <= 5) 
            {
                Console.WriteLine("Have u tried reboot PC ?");
            }
            else
            {
               Next(request);
            }
        }
    }
}
