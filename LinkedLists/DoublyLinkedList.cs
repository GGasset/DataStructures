namespace DataStructures
{
    public class DoublyLinkedList<T>
    {
        public ListItem<T> firstItem;
        private int Length;
        public DoublyLinkedList()
        {
            firstItem = null;
            Length = 0;
        }

        public int GetLength() => Length;

        ///<summary>Adds an element at the end of the list</summary>
        public T AddItem(T value)
        {
            ListItem<T> temporalItem = new ListItem(value);
            ListItem<T> transverser;
            if (firstItem == null)
                firstItem = temporalItem;
            else
            {
                transverser = firstItem;
                while (transverser.nextItem != null)
                    transverser = transverser.nextItem;
                
                temporalItem.previousItem = transverser;
                transverser.nextItem = temporalItem;
            }
            this.Length++;
            return value;
        }

        public ListItem<T> GetAt(int index)
        {
            ListItem<T> transverser = this.firstItem;
            int i = 1;
            while (i < index)
            {
                transverser = transverser.nextItem;
                i++;
            }
            return transverser;
        }

        public void RemoveAt(int index)
        {
            GetAt(index - 1).nextItem = GetAt(index + 1);
            GetAt(index + 1).previousItem = GetAt(index - 1)
            GetAt(index) = null;
        }

        public override string ToString()
        {
            string output = string.Empty;
            if (firstItem != null)
            {
                output += $"{firstItem.value} | ";
                ListItem transverser = firstItem;
                while (transverser.nextItem != null)
                {
                    transverser = transverser.nextItem;
                    output += $"{transverser.value} | ";
                }
            }
            return output;
        }

        public class ListItem<T>
        {
            public ListItem(T value)
            {
                previousItem = nextItem = null;
                this.value = value;   
            }
            public ListItem<T> previousItem;
            public T value;
            public ListItem<T> nextItem;
        }
    }
}