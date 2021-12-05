using System;

namespace DataStructures
{
    //I recommend checking Doubly Linked Lists because it has more features.
    public class SinglyLinkedList
    {
        ///<summary>Head of the list</summary>
        public ListItem firstItem;
        public int Length => length;
        private int length = 0;

        public SinglyLinkedList()
        {
            firstItem = null;
        }

        ///<summary>Adds an element at the end of the list</summary>
        public void AddItem(int value)
        {
            ListItem temporalItem = new ListItem(value);
            ListItem transverser;
            if (firstItem == null)
                firstItem = temporalItem;
            else
            {
                transverser = firstItem;
                while (transverser.nextItem != null)
                    transverser = transverser.nextItem;
                
                transverser.nextItem = temporalItem;
            }
            length++;
        }

        public ref ListItem GetAt(int index)
        {
            if (index >= length)
                throw new IndexOutOfRangeException();
            ref ListItem transverser = ref this.firstItem;
            for (int i = 1; i < index; i++)
            {
                transverser = transverser.nextItem;
            }
            return ref transverser;
        }

        public void RemoveAt(int index)
        {
            if (index == Length - 1)
                GetAt(index - 1).nextItem = null;
            else
                GetAt(index - 1).nextItem = GetAt(index + 1);
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
            public ListItem(int value)
            {
                this.value = value;
                nextItem = null;
            }
            
            public ListItem nextItem;
            public int value;
        }
    }
}