namespace Tuple
{
    public class Tuple<TFirst,TSecond>
    {
        public TFirst First { get;}
        public TSecond Second { get;}

        public Tuple(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }
    }
}
