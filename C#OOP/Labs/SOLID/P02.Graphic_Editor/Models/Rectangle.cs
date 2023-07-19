using P02.Graphic_Editor.Interfaces;

namespace P02.Graphic_Editor.Models
{
    public class Rectangle : IShape
    {
        public string Name => GetType().Name;
    }
}
