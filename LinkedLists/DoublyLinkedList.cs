using System;

namespace DataStructures
{
    public class DoublyLinkedList<T>
    {
        public ListItem firstItem;
        public ListItem LastItem => GetLast();
        private int length;
        public int Lenght => length;

        public DoublyLinkedList()
        {
            firstItem = null;
            length = 0;
        }

        public int GetLength() => length;

        ///<summary>Adds an element at the end of the list</summary>
        public T AddLast(T value)
        {
            AddAtIndex(length - 1, value);
            return value;
        }

        private ListItem GetLast()
        {
            if (length != 0)
                return GetAt(index - 1);
            return null;
        }

        public T AddAtIndex(int index, T value)
        {
            if (index == length || firstItem == null)
                AddItem(value);
            else
            {
                ListItem temporalItem = new ListItem(value);
                temporalItem.nextItem = GetAt(index);
                if (index != 0)
                    temporalItem.previousItem = GetAt(index - 1);

                GetAt(index).previousItem = temporalItem;
                if (index != 0)
                    GetAt(index - 1).nextItem = temporalItem;

                length++;
            }
            return value;
        }

        public ListItem GetAt(int index)
        {
            if (index >= length)
                throw new IndexOutOfRangeException();
            ListItem transverser = this.firstItem;
            int i = 0;
            while (i < index)
            {
                transverser = transverser.nextItem;
                i++;
            }
            return transverser;
        }

        public void RemoveLast()
        {
            RemoveAt(length - 1);
        }

        public void RemoveAt(int index)
        {
            if (index == length - 1)
            {
                GetAt(index - 1).nextItem = null;
            }
            else if(index == 0)
            {
                GetAt(index + 1).previousItem = null;
            }
            else if (length == 0)
            {
                GetAt(index - 1).nextItem = GetAt(index + 1);
                GetAt(index + 1).previousItem = GetAt(index - 1);
            }
            length--;
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

        public class ListItem
        {
            public ListItem(T value)
            {
                previousItem = nextItem = null;
                this.value = value;
            }

            public ListItem previousItem;
            public T value;
            public ListItem nextItem;
        }
    }
}
