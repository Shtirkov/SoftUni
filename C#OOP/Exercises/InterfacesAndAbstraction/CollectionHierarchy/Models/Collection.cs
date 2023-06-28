using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public abstract class Collection 
    {
        protected string[] Items { get; set; }
        protected int Index { get; set; }
        public int Length => Items.Length;

        public Collection()
        {
            Items = new string[1];
        }

        protected void Resize()
        {
                var newArr = new string[Items.Length + 1];
                Items.CopyTo(newArr, 0);
                Items = newArr;            
        }


    }
}
