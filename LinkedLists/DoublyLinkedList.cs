namespace DataStructures
{
    public class DoublyLinkedList
    {
        public ListItem firstItem;
        public DoublyLinkedList()
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
                
                temporalItem.previousItem = transverser;
                transverser.nextItem = temporalItem;
            }
        }

        public int GetAt(int index)
        {
            ListItem transverser = this.firstItem;
            for (int i = 1; i < index; i++)
            {
                transverser = transverser.nextItem;
            }
            return transverser;
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
                previousItem = nextItem = null;
                this.value = value;   
            }
            public ListItem previousItem;
            public int value;
            public ListItem nextItem;
        }
    }
}