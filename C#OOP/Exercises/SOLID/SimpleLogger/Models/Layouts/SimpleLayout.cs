using SimpleLogger.Common;
using SimpleLogger.Models.Layouts.Contracts;

namespace SimpleLogger.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => Constants.SimpleLayoutFormat;
    }
}
