using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class MyList : Collection, IAddCollection, IRemoveCollection, IMyList
    {
        public int Used => Items.Length;

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
            var removedItem = Items[0];
            var oldArr = Items;
            oldArr.CopyTo(Items, 0);
            Items[0] = null;
            Shrink();
            Index--;
            return removedItem;
        }
    }
}
