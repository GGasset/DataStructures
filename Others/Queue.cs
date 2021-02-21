namespace DataStructures
{
    /// <summary>Last in - First out structure</summary>
    class Queue<T>
    {
        DoublyLinkedList<T> values;

        /// <summary>Adds an element to the end of the queue</summary>
        public T Enqueue(T value)
        {
            values.Add(value);
            return value;
        }

        /// <summary>Removes an element from the end of the queue</summary>
        public T Dequeue()
        {
            T output = values.GetAt(0).value;
            values.RemoveAt(0);
            return output;
        }
    }
}