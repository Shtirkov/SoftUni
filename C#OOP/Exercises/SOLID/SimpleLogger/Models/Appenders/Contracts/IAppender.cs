using SimpleLogger.Models.Layouts.Contracts;

namespace SimpleLogger.Models.Appenders.Contracts
{
    public interface IAppender
    {
        public ILayout Layout { get;}

        public void Append(string message);
    }
}
