namespace TaskFromPresentationHomeWork11
{
    class ComparablePair<S, T> : IComparable<ComparablePair<S, T>> 
        where S : IComparable<S>
        where T : IComparable<T>
    {
        private S _field1;
        private T _field2;

        public S Field1
        {
            get { return _field1; }
            set { _field1 = value; }
        }

        public T Field2
        {
            get { return _field2; }
            set { _field2 = value; }
        }

        public ComparablePair()
        {
            Field1 = default(S);
            Field2 = default(T);
        }

        public ComparablePair(S field1, T field2)
        {
            Field1 = field1;
            Field2 = field2;
        }

        public int CompareTo(ComparablePair<S, T>? other)
        {
            if(other is null) return 1;
            if(this.Field1.CompareTo(other.Field1) != 0)
            {
                return this.Field1.CompareTo(other.Field1);
            }
            return this.Field2.CompareTo(other.Field2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ComparablePair<int, int> comparablePair = new ComparablePair<int, int>();
            ComparablePair<int, int> comparablePair2 = new ComparablePair<int, int>();
            var res = comparablePair.CompareTo(comparablePair2);
            if(res == 0)
            {
                Console.WriteLine("Объекты равны");
            }
            else if(res == 1)
            {
                Console.WriteLine("Объектр равнен null");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }
    }
}
