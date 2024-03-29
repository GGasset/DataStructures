namespace DataStructures
{
    /// <summary>Last in - First out structure</summary>
    public class Queue<T>
    {
        DoublyLinkedList<T> values;

        public Queue()
        {
            values = new DoublyLinkedList<T>();
        }

        /// <summary>Adds an element to the end of the queue</summary>
        public T Enqueue(T value)
        {
            values.AddLast(value);
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