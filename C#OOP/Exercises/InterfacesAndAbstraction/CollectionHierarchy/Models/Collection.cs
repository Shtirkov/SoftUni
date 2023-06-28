namespace CollectionHierarchy.Models
{
    public abstract class Collection
    {
        protected string[] Items { get; set; }
        protected int Index { get; set; }
        protected int Length => Items.Length;

        public Collection()
        {
            Items = new string[0];
            Index = -1;
        }

        protected void Resize()
        {
            var newArr = new string[Items.Length + 1];
            Items.CopyTo(newArr, 0);
            Items = newArr;
        }

        protected void Shrink()
        {
            var newArr = new string[Items.Length - 1];
            Items.Where(x => x != null).ToArray().CopyTo(newArr, 0);
            Items = newArr;
        }

    }
}
