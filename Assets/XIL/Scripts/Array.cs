namespace wxb
{
    public class Array<T>
    {
        public Array(T[] values)
        {
            this.values = values;
        }

        public Array(int value)
        {
            values = new T[value];
        }

        public T[] values;

        public T this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }
    }
}