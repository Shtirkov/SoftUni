using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection : Collection, IAddCollection
    {
        public int Add(string item)
        {
            Index++;
            var oldArr = Items;
            Resize();
            oldArr.CopyTo(Items, 0);
            Items[Index] = item;
            return Index;
        }
    }
}
