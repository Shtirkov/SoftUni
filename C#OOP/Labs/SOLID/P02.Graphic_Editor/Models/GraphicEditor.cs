using P02.Graphic_Editor.Interfaces;
using System;

namespace P02.Graphic_Editor.Models
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine($"I'm {shape.Name}");
        }
    }
}
