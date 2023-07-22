using SimpleLogger.Models.Appenders.Contracts;
using SimpleLogger.Models.Layouts.Contracts;

namespace SimpleLogger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;   
        }

        public ILayout Layout { get; }

        public void Append(string message) => Console.WriteLine(message);
    }
}
