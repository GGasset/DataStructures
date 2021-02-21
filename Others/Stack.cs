namespace DataStructures
{
    /// <summary>Last in - Last out structure</summary>
    class Stack<T>
    {
        DoublyLinkedList<T> values;
        
        /// <summary>Adds an item at the end of the Stack</summary>
        public T AddItem(T value)
        {
            values.Add(value);
        }

        /// <summary>Get Last item without removing it</summary>
        public T Peak() => values.lastItem.value;

        /// <summary>Get and remove the last item</summary>
        public T TakeLast()
        {
            T value = values.lastItem.value;
            values.RemoveLast();
            return value;
        }
    }
}