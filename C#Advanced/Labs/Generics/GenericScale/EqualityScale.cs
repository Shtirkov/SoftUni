namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T _first;
        private T _second;

        public EqualityScale(T first, T second)
        {
            _first = first;
            _second = second;
        }

        public bool AreEqual() => _first.Equals(_second);
    }
}
