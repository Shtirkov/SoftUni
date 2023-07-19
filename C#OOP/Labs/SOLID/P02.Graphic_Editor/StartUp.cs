using P02.Graphic_Editor.Interfaces;
using P02.Graphic_Editor.Models;
using System.Collections.Generic;

namespace P02.Graphic_Editor
{
    public class StartUp
    {
        static void Main()
        {
            var shapes = new List<IShape> { new Circle(), new Rectangle(), new Square()};
            var editor = new GraphicEditor();
            shapes.ForEach(shape => editor.DrawShape(shape));
        }
    }
}
