using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection : Collection, IAddCollection
    {
        public void Add(string item)
        {
            var oldArr = Items;           
            Resize();
            oldArr.CopyTo(Items, 1);
            Items[0] = item;
            Index++;
        }
    }
}
