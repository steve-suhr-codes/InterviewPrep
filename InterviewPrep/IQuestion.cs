namespace InterviewPrep
{
    public interface IQuestion
    {
        string Command { get; }
        string Description { get; }
        void Run();
    }
}
