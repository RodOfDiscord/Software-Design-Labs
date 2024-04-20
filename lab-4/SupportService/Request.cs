namespace SupportService
{
    public class Request
    {
        public int ProblemDifficulty { get; set; }

        public Request(int problemDifficulty)
        {
            ProblemDifficulty = problemDifficulty;
        }
    }
}
