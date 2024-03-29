namespace DataStructures
{
    /// <summary>Last in - Last out structure</summary>
    class Stack<T>
    {
        DoublyLinkedList<T> values;
        
        public Stack()
        {
            values = new DoublyLinkedList<T>();
        }

        /// <summary>Adds an item at the end of the Stack</summary>
        public T AddItem(T value)
        {
            values.AddLast(value);
            return value;
        }

        /// <summary>Get Last item without removing it</summary>
        public T Peak() => values.LastItem.value;

        /// <summary>Get and remove the last item</summary>
        public T TakeLast()
        {
            T value = values.LastItem.value;
            values.RemoveLast();
            return value;
        }
    }
}