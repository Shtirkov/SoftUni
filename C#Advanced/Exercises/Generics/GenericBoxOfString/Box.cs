namespace Box
{
    public class Box<T>
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
    }
}
