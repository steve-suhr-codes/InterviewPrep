using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    /// <summary>
    /// Given a long string, break it into lines that contain as many words as possible up to
    /// a certain length. Concatenate words with a "-". If a single word is longer than the max
    /// wrap that word.
    /// </summary>
    public class WordWrap : IQuestion
    {
        public string Command => "word-wrap";
        public string Description => "Run the WordWrap question";

        public void Run()
        {
            var textToWrap = "reeeeeaaaalllylongword I test something test as something to test. More text here.";
            var lineLength = 10;
            var linesToWrap = textToWrap.Split(" ");
            var lines = new List<string>();

            var sb = new StringBuilder();
            for (var i = 0; i < linesToWrap.Length; i++)
            {
                var line = linesToWrap[i];

                if (line.Length > lineLength)
                {
                    lines.Add(line.Substring(0, lineLength));
                    linesToWrap[i] = line.Substring(lineLength);
                    i--;
                }
                else if (sb.Length + line.Length <= lineLength)
                {
                    sb.Append(line);
                    sb.Append("-");
                }
                else
                {
                    lines.Add(sb.ToString(0, sb.Length - 1));
                    sb.Clear();
                    i--;
                }
            }
            lines.Add(sb.ToString(0, sb.Length - 1));
            sb.Clear();

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
