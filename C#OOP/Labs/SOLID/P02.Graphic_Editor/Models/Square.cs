using P02.Graphic_Editor.Interfaces;

namespace P02.Graphic_Editor.Models
{
    public class Square : IShape
    {
        public string Name => GetType().Name;
    }
}
