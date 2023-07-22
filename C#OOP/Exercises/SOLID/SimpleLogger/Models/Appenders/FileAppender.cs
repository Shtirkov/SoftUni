using SimpleLogger.Models.Appenders.Contracts;
using SimpleLogger.Models.Files.Contracts;
using SimpleLogger.Models.Layouts.Contracts;

namespace SimpleLogger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout, IFile file)
        {
            Layout = layout;
            File = file;
        }

        public ILayout Layout { get; }

        public IFile File { get; set; }

        public void Append(string message)
        {
            throw new NotImplementedException();
        }
    }
}
