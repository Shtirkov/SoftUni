namespace Box
{
    public class Box<T> where T : IComparable<T>
    {
        private readonly T _value;

        public Box(T value)
        {
            _value = value;
        }

        public override string ToString() => $"{typeof(T).FullName}: {_value}";

        public static List<Box<T>> Swap(List<Box<T>> elements, int firstIndex, int secondIndex)
        {
            var firstElement = elements[firstIndex];
            var secondElement = elements[secondIndex];
            elements[firstIndex] = secondElement;
            elements[secondIndex] = firstElement;

            return elements;
        }

        public static int GetValidElementsCount(List<Box<T>> elements, T element) => elements.Where(e => e._value.CompareTo(element) > 0).ToList().Count;
    }
}
