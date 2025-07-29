using System.CommandLine;

namespace InterviewPrep
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var questions = new IQuestion[]
            {
                new WordWrap(),
                new BubbleSort()
            };

            var rootCommand = new RootCommand("InterviewPrep questions");

            foreach (var question in questions)
            {
                var cmd = new Command(question.Command, question.Description);
                cmd.SetHandler(() => question.Run());
                rootCommand.AddCommand(cmd);
            }

            return await rootCommand.InvokeAsync(args);
        }
    }
}
