using SimpleLogger.Common;
using SimpleLogger.Enumerations;
using SimpleLogger.Models.Files.Contracts;

namespace SimpleLogger.Models.Files
{
    public abstract class File : IFile
    {
        public string Name => Constants.DefaultLogFileName;

        public long Size => CalculateFileSize();

        public string Directory { get; }

        public string FileContent { get; }

        public Level Level { get; }

        protected long CalculateFileSize()
        {
            var fileSize = 0l;

            foreach (var character in FileContent)
            {
                if (char.IsLetter(character))
                {
                    fileSize += character;
                }
            }

            return fileSize;
        }
    }
}
