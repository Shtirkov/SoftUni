namespace Tuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public TFirst First { get; }
        public TSecond Second { get; }
        public TThird Third { get;}

        public Threeuple(TFirst first, TSecond second, TThird third)
        {
            First = first;
            Second = second;
            Third = third;
        }
    }
}
