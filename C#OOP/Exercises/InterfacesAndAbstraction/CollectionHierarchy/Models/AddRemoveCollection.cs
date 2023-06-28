using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : Collection, IAddCollection, IRemoveCollection
    {
        public int Add(string item)
        {
            Index++;
            var oldArr = Items;
            Resize();
            oldArr.CopyTo(Items, 1);
            Items[0] = item;
            return 0;
        }

        public string Remove()
        {
            var removedItem = Items[Index];
            var oldArr = Items;
            oldArr.CopyTo(Items, 0);
            Items[Index] = null;
            Shrink();
            Index--;
            return removedItem;
        }
    }
}
