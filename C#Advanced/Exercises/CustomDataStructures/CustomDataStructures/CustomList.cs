namespace CustomDataStructures
{
    public class CustomList
    {
        private const int _initialCapacity = 2;
        private int[] _items;

        public CustomList()
        {
            _items = new int[_initialCapacity];   
        }

        public int Count { get; private set; }

        public int Indexer { get; set; }
    }
}
