namespace genericsDemo
{
    using System;
    public class Repository<T>
    {
        private T data;
        public Repository()
        {

        }
        public Repository(T data)
        {
            this.data = data;
        }

       public void Print()
        {
            Console.WriteLine(string.Join(",", this.data));
        }
    }
}
