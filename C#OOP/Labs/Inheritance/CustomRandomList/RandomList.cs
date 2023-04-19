namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var rand = new Random();
            var elementToRemove = base[rand.Next(0, Count - 1)];
            Remove(elementToRemove);
            return elementToRemove;
        }
    }
}
