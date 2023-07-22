using SimpleLogger.Enumerations;

namespace SimpleLogger.Models.Files.Contracts
{
    public interface IFile
    {
        public string Name { get; } 
        
        public long Size { get; }  

        public string Directory { get; }

        public Level Level { get; }

        public string FileContent { get; }  
    }
}
